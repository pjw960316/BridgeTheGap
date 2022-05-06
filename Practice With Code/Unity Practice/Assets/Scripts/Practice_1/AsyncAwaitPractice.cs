using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Threading;
using UnityEngine;

//�ѿ��� �������� ���븦 ĥ ���� ��Ȳ�� ������� �����带 �̿��ؼ� �����غ���

/*�ó�����
 * 1. �ش� Ŭ������ start�� �� �������� ��ų�� ���͸� �����Ѵٰ� ��������
 * 2. �������� ��ų �������� �Ϻ��ϰ� ����� ��(����� 5�� �ɸ��ٰ� ��������) �β��� �������� ��´�.
 * 3. �������� ������ ����� task�� �����Ѵ�.
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
