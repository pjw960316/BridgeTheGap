using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graves : Champions
{
    public override void UseQSkill()
    {
        Debug.Log("Q");
    }
    public override void UseWSkill()
    {
        Debug.Log("W");
    }
    public override void UseESkill()
    {
        Debug.Log("E");
    }
    public override void UseRSkill()
    {
        Debug.Log("R");
    }
}
