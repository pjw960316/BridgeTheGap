using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;

public class TaskPractice : MonoBehaviour
{
    void Start()
    {
        //action1은 매개변수 1개의 메소드로 이루어져 있고 2개의 메소드가 저장되어 있다.
        Action<object> action1 = new Action<object>(Func);
        action1 += Func2;

        //action2는 매개변수 2개의 메소드로 이루어져 있고 1개의 메소드가 저장되어 있다.
        Action<object, object> action2 = new Action<object, object>(Func3);

        Task.Run(() => action1("a"));
        
        Task.Run(() => action2("a", "b"));

        for(int i=0; i<20; i++)
        {
            Debug.Log("main thread" + i);
        }

        //Bad Way
        //Task t1 = new Task(action , "1번");
        //t1.Start();
       
        

        ////using task without delegate(action) just method
        //Task t2 = new Task(Func, "2번");
        //t2.Start();
    }       

    void Func(object a)
    {
        for(int i=0; i<20; i++)
        {
            Debug.Log(a + " 1번 메소드 "+  i);
        }
    }
    void Func2(object a)
    {
        for (int i = 0; i < 20; i++)
        {
            Debug.Log(a + " 2번 메소드 " + i);
        }
    }


    void Func3(object a , object b)
    {
        for (int i = 0; i < 20; i++)
        {
            Debug.Log(a + " " +b + " " + i);
        }
    }
}
