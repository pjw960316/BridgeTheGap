using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;

public class TaskPractice : MonoBehaviour
{
    void Start()
    {
        //action1�� �Ű����� 1���� �޼ҵ�� �̷���� �ְ� 2���� �޼ҵ尡 ����Ǿ� �ִ�.
        Action<object> action1 = new Action<object>(Func);
        action1 += Func2;

        //action2�� �Ű����� 2���� �޼ҵ�� �̷���� �ְ� 1���� �޼ҵ尡 ����Ǿ� �ִ�.
        Action<object, object> action2 = new Action<object, object>(Func3);

        Task.Run(() => action1("a"));
        
        Task.Run(() => action2("a", "b"));

        for(int i=0; i<20; i++)
        {
            Debug.Log("main thread" + i);
        }

        //Bad Way
        //Task t1 = new Task(action , "1��");
        //t1.Start();
       
        

        ////using task without delegate(action) just method
        //Task t2 = new Task(Func, "2��");
        //t2.Start();
    }       

    void Func(object a)
    {
        for(int i=0; i<20; i++)
        {
            Debug.Log(a + " 1�� �޼ҵ� "+  i);
        }
    }
    void Func2(object a)
    {
        for (int i = 0; i < 20; i++)
        {
            Debug.Log(a + " 2�� �޼ҵ� " + i);
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
