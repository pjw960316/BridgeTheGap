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

//���Ǳ⿡�� �������� ���Ḧ �̴� ���� ��������
public class Machine
{    
    public class bottle_info
    {
        //�̷� ���� �ڷ� Ŭ������ ���� private set�� �� �ʿ䰡 ������
        //public string name { get; private set; }
        //public int count { get; private set; }
        //public int price { get; private set; }
        public string name;
        public int count;
        public int price;

        public bottle_info(string a, int b, int c)
        {
            name = a;
            count = b;
            price = c;
        }
    };

    private List<bottle_info> bottles;

    //��ü������ ���󿡼��� ���ǱⰡ �ڽ��� ��ġ�� �����Ѵ�.
    Machine()
    {
        bottles.Add(new bottle_info("coke", 10, 500));
        bottles.Add(new bottle_info("orange_juice", 12, 500));
    }

    //�̷��� �翬�� map�� key�� �̿��ϴ°� ������.
    private void ChangeStatesFromAlice(string bottle_name , int count)
    {    
        for(int i=0; i<bottles.Count; i++)
        {
            if(bottles[i].name == "coke")
            {
                bottles[i].count -= count;
            }
        }
    }

}
