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
        FirstBlood += nokturn.GetGold; //퍼스트 블러드가 발생했을 때 호출할 메소드의 주소를 이벤트 처리기에 등록시킨다.
        FirstBlood(this,EventArgs.Empty);
    }
}

public class Character
{
    public int gold { get; private set; } //객체의 상태는 숨긴다.

    public Character()
    {
        gold = 0;
    }
    public void GetGold(object sender, EventArgs e) //객체의 행동은 나타낸다. 캐릭터가 자신의 보유 골드 상태를 증가시킨다.
    {
        gold += 400;
        Debug.Log(gold);
    }
}
