using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventHandlerPractice : MonoBehaviour
{
    EventHandler FirstBlood;
    private Character nokturn;

    private void Start()
    {
        nokturn = new Character();
        FirstBlood += nokturn.GetGold; //�۽�Ʈ ���尡 �߻����� �� ȣ���� �޼ҵ��� �ּҸ� �̺�Ʈ ó���⿡ ��Ͻ�Ų��.
        FirstBlood(this,EventArgs.Empty);
    }
}

public class Character
{
    public int gold { get; private set; } //��ü�� ���´� �����.

    public Character()
    {
        gold = 0;
    }
    public void GetGold(object sender, EventArgs e) //��ü�� �ൿ�� ��Ÿ����. ĳ���Ͱ� �ڽ��� ���� ��� ���¸� ������Ų��.
    {
        gold += 400;
        Debug.Log(gold);
    }
}
