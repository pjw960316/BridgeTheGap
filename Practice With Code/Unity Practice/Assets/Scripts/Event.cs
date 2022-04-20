using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    delegate void MyDelegate();
    event MyDelegate delegate_object;

    void Start()
    {
        delegate_object = new MyDelegate(Func1);
        delegate_object += Func2;
        delegate_object();
    }

    void Func1()
    {
        Debug.Log("Func1 call");
    }

    void Func2()
    {
        Debug.Log("Func2 call");
    }



}
