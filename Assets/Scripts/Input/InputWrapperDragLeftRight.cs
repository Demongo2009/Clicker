using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputWrapperDragLeftRight : IInputWrapper
{
    public bool IsTouchBegin()
    {
        if (Input.touchCount <= 0)
        {
            return false;
        }

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            return true;
        }

        return false;
    }

    public bool IsTouchEnd()
    {
        if (Input.touchCount <= 0)
        {
            return false;
        }

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Ended)
        {
            return true;
        }
        
        return false;

    }

    public bool IsTouchMoved()
    {
        return true;
    }
}
