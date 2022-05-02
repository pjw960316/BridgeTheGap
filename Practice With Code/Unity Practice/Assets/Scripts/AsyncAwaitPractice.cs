using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwaitPractice : MonoBehaviour
{
    Task my_task;
    void Start()
    {
        Action action = new Action(Func1);

        my_task = Task.Run(action);
        
    }

    async void Func1()
    {
        for(int i=0; i<20; i++)
        {
            Debug.Log("1¹ø" + i);
        }
        await my_task; 
    }
    void Func2()
    {
        for (int i = 0; i < 20; i++)
        {
            Debug.Log("1¹ø" + i);
        }
    }
}
