using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter2 : MonoBehaviour
{   
    //empty
}

public class Alice : MonoBehaviour
{
    private Ticket alices_ticket;
    private Coke alices_coke;

    private void Start()
    {
        alices_ticket = new Ticket(60000 , "A2");
        alices_coke = new Coke(new Vector3(1, 1, 1));

    }

}

//엘리스가 비행기를 타기 위한 티켓이라고 가정하자.
//티켓이 간단해보이지만 소프트웨어 세계라면 티켓은 스스로 사라질 수도 있고 스스로 계산될 수도 있기 때문에 method도 생기게 된다.
//script를 분할하는 것이 맞아 보인다.
public class Ticket
{
    public int price;
    public string seat;

    public Ticket(int money , string str)
    {
        price = money;
        seat = str;
    }
}

public class Coke
{
    Vector3 location;
    bool is_alice_touch;

    public Coke(Vector3 loc)
    {
        location = loc;
        this.is_alice_touch = false;
    }
}
