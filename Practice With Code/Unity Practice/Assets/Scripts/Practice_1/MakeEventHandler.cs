using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MakeEventHandler : MonoBehaviour
{
    EventHandler event_handler;   
    
    private void Start()
    {
        event_handler += TestFunction;
        object tmp = null;
        EventArgs tmp2 = null;
        event_handler(tmp , tmp2);
    }

    private void TestFunction(object sender , EventArgs s)
    {
        Debug.Log("So Easy!");
        return;
    }
}
