using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;

public class TaskPractice : MonoBehaviour
{
    void Start()
    {
        Action<object> action = new Action<object>(Func);

        Task t1 = new Task(action , "1¹ø");
        t1.Start();

        //using task without delegate(action) just method
        Task t2 = new Task(Func, "2¹ø");
        t2.Start();
    }       

    void Func(object a)
    {
        for(int i=0; i<100; i++)
        {
            Debug.Log(a + " " + i);
        }
    }
}
