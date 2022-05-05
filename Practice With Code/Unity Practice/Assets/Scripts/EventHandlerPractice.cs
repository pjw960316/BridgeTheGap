using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventHandlerPractice : MonoBehaviour
{
    EventHandler FirstBlood;
    
    private void Start()
    {
        AddEvents();
        FirstBlood(null , null);
    }


    private void AddEvents()
    {
        FirstBlood += GetGolds;
    }

    private void GetGolds(object sender , EventArgs e)
    {
        Debug.Log("Log : " + sender + " " + e);
    }
}
