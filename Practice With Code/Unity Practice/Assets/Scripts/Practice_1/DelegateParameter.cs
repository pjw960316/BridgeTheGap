using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class DelegateParameter : MonoBehaviour
{
    delegate void MyDelegate();

    private void Awake()
    {
        DelegateParameter obj = new DelegateParameter();
        ThreadPool.QueueUserWorkItem(obj.Test);
        ThreadPool.QueueUserWorkItem(Test);

    }

    private void Test(object obj)
    {
        Debug.Log("parameter is delegate or function");
    }
}
