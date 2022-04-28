using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Text;

public class ActionPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Action non_params = new Action(DoSomething2);
        non_params();

        Action<string> parameters = new Action<string>(DoSomething);
        parameters("do1");
    }

    private static void DoSomething(string str)
    {
        Debug.Log(str);
    }

    private static void DoSomething2()
    {
        Debug.Log("do2");
    }

}
