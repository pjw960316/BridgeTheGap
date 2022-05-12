using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champions : MonoBehaviour
{
    //챔피언 클래스의 모든 객체는 q,w,e,r 스킬을 사용한다. (행동)
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) == true)
        {
            UseQSkill();
        }
        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            UseWSkill();
        }
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            UseESkill();
        }
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            UseRSkill();
        }
    }

    public virtual void UseQSkill()
    {

    }
    public virtual void UseWSkill()
    {

    }
    public virtual void UseESkill()
    {

    }
    public virtual void UseRSkill()
    {

    }
}
