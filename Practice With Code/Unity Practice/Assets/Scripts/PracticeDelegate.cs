using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Person
{
    public int hp;
    public int mp;
    public int exp;

    public Person(int hp, int mp, int exp)
    {
        this.hp = hp;
        this.mp = mp;
        this.exp = exp;
    }
}

[SerializeField]
public class PracticeDelegate : MonoBehaviour
{
    delegate void myDelegate(int number);
    myDelegate delegate_object;


    Person jiwon;

    private void Awake()
    {
        jiwon = new Person(100 , 100 , 0);
        InitializeDelegateInstance();
    }

    private void InitializeDelegateInstance()
    {
        delegate_object = null;
        //delegate_object = new myDelegate(IncreaseHp);
        delegate_object += IncreaseHp;
        delegate_object += IncreaseMp;
        delegate_object += IncreaseExp;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) == true)
        {
            IncreaseThings(30, IncreaseHp);
            IncreaseThings(30, IncreaseMp);
            IncreaseAll(10);
            Show();
        }
    }

    //1. delegate for call-back
    private void IncreaseThings(int number, myDelegate delegate_obj)
    {
        delegate_obj(number);
        return;
    }

    //2. delegate chain
    private void IncreaseAll(int number)
    {
        delegate_object(number);
    }
      
    private void IncreaseHp(int number)
    {
        jiwon.hp += number;
    }
    private void IncreaseMp(int number)
    {
        jiwon.mp += number;
    }
    private void IncreaseExp(int number)
    {
        jiwon.exp += number;
    }

    private void Show()
    {
        Debug.Log(jiwon.hp);
        Debug.Log(jiwon.mp);
        Debug.Log(jiwon.exp);
    }
}
