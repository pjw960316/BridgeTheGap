using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefEnemyChild : Enemy
{
    int a = 10;
    private void Start()
    {
        Debug.Log(this.a);
        Debug.Log(name);
        base.HitPeople();
        this.HitPeople();
    }

    public override void HitPeople()
    {        
        Debug.Log("hihihihi");
    }
}

public class Tmp : MonoBehaviour //Start는 효력을 발생하지 못합니다.
{
    int b = 11;
    private void Start()
    {
        Debug.Log("why not call");
        Debug.Log(this.b);
    }
}