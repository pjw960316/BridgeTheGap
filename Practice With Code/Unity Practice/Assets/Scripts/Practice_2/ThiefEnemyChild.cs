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

public class Tmp : MonoBehaviour //Start�� ȿ���� �߻����� ���մϴ�.
{
    int b = 11;
    private void Start()
    {
        Debug.Log("why not call");
        Debug.Log(this.b);
    }
}