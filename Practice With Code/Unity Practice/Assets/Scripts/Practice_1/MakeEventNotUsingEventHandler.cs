using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


// �̺�Ʈ�� ���� ��������Ʈ�� ���� ����� ���
// �ſ� ������.
public class MakeEventNotUsingEventHandler : MonoBehaviour
{    
    delegate void MyHandler();
    event MyHandler my_handler;
    private void Start()
    {
        MakeDelegate();
        my_handler();
    }

    private void MakeDelegate()
    {
        my_handler += TestFunction;
    }   
    private void TestFunction()
    {
        Debug.Log("Test");
        return;
    }
    
}
