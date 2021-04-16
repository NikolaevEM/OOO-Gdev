#ifndef __TEST_SCENE_H__
#define __TEST_SCENE_H__

#include "cocos2d.h"

class TestScene : public cocos2d::Scene
{
public:
    static cocos2d::Scene* createScene();

    virtual bool init();

    // a selector callback

    // implement the "static create()" method manually
    CREATE_FUNC(TestScene);

    void Cursor(Ref* pSender);
    void onMouseDown();
    void onMouseUp();
    void onMouseMove();
    
};

#endif // __TEST_SCENE_H__#pragma once
