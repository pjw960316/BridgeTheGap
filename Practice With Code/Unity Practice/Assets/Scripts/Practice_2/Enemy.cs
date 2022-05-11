using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public virtual void HitPeople()
    {
        Debug.Log("hit people");
    }
}
