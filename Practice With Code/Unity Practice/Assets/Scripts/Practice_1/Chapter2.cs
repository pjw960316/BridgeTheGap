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

//자판기에서 엘리스가 음료를 뽑는 것을 가정하자
public class Machine
{    
    public class bottle_info
    {
        //이런 순수 자료 클래스는 굳이 private set을 할 필요가 있을까
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

    //객체지향의 세상에서는 자판기가 자신의 수치를 관리한다.
    Machine()
    {
        bottles.Add(new bottle_info("coke", 10, 500));
        bottles.Add(new bottle_info("orange_juice", 12, 500));
    }

    //이런건 당연히 map의 key를 이용하는게 빠르다.
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
