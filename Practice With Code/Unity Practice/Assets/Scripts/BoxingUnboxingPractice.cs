using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoxingUnboxingPractice : MonoBehaviour
{
    private void Start()
    {
        int a = 2;
        object b = a;
        Debug.Log(b);

        List<object> list = new List<object>();
        list.Add("abc");
        list.Add(1);
        list.Add(new EventArgs());

        foreach(var i in list)
        {
            Debug.Log(i);
        }
    }
}
