using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Champions : MonoBehaviour
{
    //è�Ǿ� Ŭ������ ��� ��ü�� q,w,e,r ��ų�� ����Ѵ�. (�ൿ)
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
