using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


// 이벤트를 위한 델리게이트를 직접 만드는 경우
// 매우 귀찮다.
public class MakeEventNotUsingEventHandler : MonoBehaviour
{    
    delegate void MyHandler();
    event MyHandler my_handler;
    private void Start()
    {
        MakeDelegate();
        my_handler();
    }

    private void MakeDelegate()
    {
        my_handler += TestFunction;
    }   
    private void TestFunction()
    {
        Debug.Log("Test");
        return;
    }
    
}
