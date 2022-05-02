using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using System.Threading.Tasks;

public class AsyncProgrammingMSDN : MonoBehaviour
{
    private void Start()
    {
        Chef.DoExampleOne();
        //Chef.DoExampleTwo();
        //Chef.DoExampleThree();
    }
    
}

public static class Chef
{
    public static void DoExampleOne()
    {
        PourCoffee();
        FryBacon();
        MakeToast();
        MakeToast2();
        PourJuice();
    }
    public static void DoExampleTwo()
    {
        Task task1 = Task.Run(PourCoffee);
        Task task2 = Task.Run(FryBacon);
        Task task3 = Task.Run(MakeToast);
    }

    public static async void DoExampleThree()
    {
        Task task1 = Task.Run(PourCoffee);
        await task1;
        Task task2 = Task.Run(FryBacon);
        Task task3 = Task.Run(MakeToast);
    }
    public static void PourCoffee()
    {
        Debug.Log("Pour coffee start");
        Task.Delay(3000).Wait();
        Debug.Log("Pour coffee end");
    }

    public static void FryBacon()
    {
        Debug.Log("Fry Bacon start");
        Task.Delay(3000).Wait();
        Debug.Log("Fry Bacon end");
    }
    public static void MakeToast()
    {
        Debug.Log("MakeToast start");
        Task.Delay(3000).Wait();
        Debug.Log("MakeToast end");
    }

    public static void MakeToast2()
    {
        Debug.Log("MakeToast2 start, always start after MakeToast1 End");
        Task.Delay(3000).Wait();
        Debug.Log("MakeToast2 end");
    }

    public static void PourJuice()
    {
        Debug.Log("PourJuice start");
        Task.Delay(3000).Wait();
        Debug.Log("PourJuice end");
    }
}
  
