/****************************************************************************
 Copyright (c) 2017-2018 Xiamen Yaji Software Co., Ltd.
 
 http://www.cocos2d-x.org
 
 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:
 
 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.
 
 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.
 ****************************************************************************/

#include "HelloWorldScene.h"
#include "TestScene.h"
//include ñöåíó èãğû

USING_NS_CC;

Scene* HelloWorld::createScene()
{
    return HelloWorld::create();
}

static void problemLoading(const char* filename)
{
    printf("Error while loading: %s\n", filename);
    printf("Depending on how you compiled you might have to add 'Resources/' in front of filenames in HelloWorldScene.cpp\n");
}

bool HelloWorld::init()
{

    if ( !Scene::init() )
    {
        return false;
    }

    Director::getInstance()->getOpenGLView()->setFrameSize(557, 625);
    Director::getInstance()->getOpenGLView()->setDesignResolutionSize(557, 625, ResolutionPolicy::EXACT_FIT);

    auto visibleSize = Director::getInstance()->getVisibleSize();
    Vec2 origin = Director::getInstance()->getVisibleOrigin();

    auto menu_Item_1 = MenuItemFont::create("Start", CC_CALLBACK_1(HelloWorld::Start, this));
    auto menu_Item_2 = MenuItemFont::create("Shop", CC_CALLBACK_1(HelloWorld::Shop, this));
    auto menu_Item_3 = MenuItemFont::create("Settings", CC_CALLBACK_1(HelloWorld::Settings, this));
    auto menu_Item_4 = MenuItemFont::create("Profiles", CC_CALLBACK_1(HelloWorld::Settings, this));
    auto menu_Item_5 = MenuItemFont::create("Exit", CC_CALLBACK_1(HelloWorld::Exit, this));
    auto* menu = Menu::create(menu_Item_1, menu_Item_2, menu_Item_3, menu_Item_4, menu_Item_5, NULL);

    auto sprite = Sprite::create("MainMenu.png");
    if (sprite == nullptr)
    {
        problemLoading("'MainMenu.png'");
    }
    else
    {
        sprite->setPosition(Vec2(visibleSize.width/2 + origin.x, visibleSize.height/2 + origin.y));
        this->addChild(sprite, 0);
    }

    menu->alignItemsVertically();
    this->addChild(menu);

    return true;
}

void HelloWorld::Start(cocos2d::Ref* pSpender)
{
    // Âìåñòî HelloWorld ñöåíà èãğû
    CCLOG("Start");
    auto scene = TestScene::createScene();
    Director::getInstance()->replaceScene(scene);
}

void HelloWorld::Shop(cocos2d::Ref* pSpender)
{
    CCLOG("Shop");
}

void HelloWorld::Settings(cocos2d::Ref* pSpender)
{
    CCLOG("Settings");
}

void HelloWorld::Profiles(cocos2d::Ref* pSpender)
{
    CCLOG("Profiles");
}

void HelloWorld::Exit(Ref* pSender)
{
    Director::getInstance()->end();
}