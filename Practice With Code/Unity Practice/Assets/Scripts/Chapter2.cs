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

//�������� ����⸦ Ÿ�� ���� Ƽ���̶�� ��������.
//Ƽ���� �����غ������� ����Ʈ���� ������ Ƽ���� ������ ����� ���� �ְ� ������ ���� ���� �ֱ� ������ method�� ����� �ȴ�.
//script�� �����ϴ� ���� �¾� ���δ�.
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
