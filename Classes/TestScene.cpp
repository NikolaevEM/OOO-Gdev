#include "TestScene.h"
#include <iostream>
 //include сцену игры

USING_NS_CC;

Scene* TestScene::createScene()
{
    return TestScene::create();
}

static void problemLoading(const char* filename)
{
    printf("Error while loading: %s\n", filename);
    printf("Depending on how you compiled you might have to add 'Resources/' in front of filenames in HelloWorldScene.cpp\n");
}

bool TestScene::init()
{

    if (!Scene::init())
    {
        return false;
    }

    Director::getInstance()->getOpenGLView()->setFrameSize(557, 625);
    Director::getInstance()->getOpenGLView()->setDesignResolutionSize(557, 625, ResolutionPolicy::EXACT_FIT);

    auto visibleSize = Director::getInstance()->getVisibleSize();
    Vec2 origin = Director::getInstance()->getVisibleOrigin();

    auto listener = EventListenerMouse::create();
    listener->onMouseDown = [](cocos2d::Event* event) {

        try {
            EventMouse* mouseEvent = dynamic_cast<EventMouse*>(event);
            mouseEvent->getMouseButton();
            //std::stringstream message;
            //message << "Mouse event: Button: " << mouseEvent->getMouseButton() << "pressed at point (" <<
                //mouseEvent->getLocation().x << "," << mouseEvent->getLocation().y << ")";
            //MessageBox(message.str().c_str(), "Mouse Event Details");

        }
        catch (std::bad_cast& e) {
            // Not sure what kind of event you passed us cocos, but it was the wrong one
            return;
        }
    };

    listener->onMouseMove = [](cocos2d::Event* event) {
        // Cast Event to EventMouse for position details like above
        cocos2d::log("Mouse moved event");
        EventMouse* mouseEvent = dynamic_cast<EventMouse*>(event);
        mouseEvent->getMouseButton();
        std::string x = std::to_string((int)mouseEvent->getLocation().x);
        char const* xx = x.c_str();  //use char const* as target type
        cocos2d::log(xx);

        std::string y = std::to_string((int)mouseEvent->getLocation().y);
        char const* yy = y.c_str();  //use char const* as target type
        cocos2d::log(yy);


    };

    listener->onMouseScroll = [](cocos2d::Event* event) {
        cocos2d::log("Mouse wheel scrolled");
    };

    listener->onMouseUp = [](cocos2d::Event* event) {
        cocos2d::log("Mouse button released");
    };

    _eventDispatcher->addEventListenerWithFixedPriority(listener, 1);
    

    return true;
}
