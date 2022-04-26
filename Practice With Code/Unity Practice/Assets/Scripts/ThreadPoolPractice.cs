using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ThreadPoolPractice : MonoBehaviour
{
    private void Awake()
    {
        int thread_count = -1;
        int thread_count_sub = -1;
        ThreadPool.GetAvailableThreads(out thread_count , out thread_count_sub);
        Debug.Log("thread count " + " " + thread_count + " " + thread_count_sub);
        ThreadPool.QueueUserWorkItem(Repeat, 'a');
        ThreadPool.QueueUserWorkItem(Repeat, 'b');
        ThreadPool.QueueUserWorkItem(Repeat, 'c');

    }
    
    private void Repeat(object obj)
    {
        for(int i=0; i<100; i++)
        {
            Debug.Log(obj + " " + i);
        }
    }
}
