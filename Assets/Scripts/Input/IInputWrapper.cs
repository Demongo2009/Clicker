using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputWrapper
{
    bool IsTouchBegin();

    bool IsTouchEnd();

    bool IsTouchMoved();
}
