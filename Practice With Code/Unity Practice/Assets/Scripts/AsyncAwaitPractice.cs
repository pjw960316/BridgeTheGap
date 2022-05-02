using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Threading;
using UnityEngine;

//롤에서 엘리스가 늑대를 칠 때의 상황을 쓸대없이 스레드를 이용해서 구현해보자

/*시나리오
 * 1. 해당 클래스가 start할 때 엘리스가 스킬로 몬스터를 공격한다고 가정하자
 * 2. 엘리스의 스킬 데미지를 완벽하게 계산한 후(계산이 5초 걸린다고 가정하자) 두꺼비가 데미지를 얻는다.
 * 3. 엘리스의 데미지 계산을 task로 진행한다.
 */
public class AsyncAwaitPractice : MonoBehaviour
{
    private JungleMonster wolf;
    private Elise elise;
    private void Start()
    {
        wolf = new JungleMonster(10, 900);
        elise = new Elise(10, 120, 0, 18);
        GameStart();        
    }  
    
    private async void GameStart()
    {
        Task measure_damage = Task.Run(new Action(elise.MeasureSkillDamage));
        await measure_damage;
        Debug.Log(elise.skill_damage);
    }
}

public class Elise
{
    public float skill_cool { get; private set; }
    public float ap { get; private set; }
    public float skill_damage { get; private set; }
    public float magwan { get; private set; }

    public Elise(int a , int b ,int c , int d)
    {
        skill_cool = a;
        ap = b;
        skill_damage = c;
        magwan = d;
    }

    public void MeasureSkillDamage()
    {
        Thread.Sleep(3000);       
        skill_damage = ap * 0.7f + 180;
    }

}

public class JungleMonster
{
    public int magic_resistance { get; private set; }
    public int hp { get; private set; }

    public JungleMonster(int a , int b)
    {
        magic_resistance = a;
        hp = b;
    }
}
