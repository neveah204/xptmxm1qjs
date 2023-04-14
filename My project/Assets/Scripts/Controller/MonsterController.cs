using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_hp = 5;                              // ���� Monster_hp �� ���� �� 5�� ����

    public void Monster_Damaged(int damage)                 
    {
        Monster_hp -= damage;                               // Monster_hp �� ������� ������ - damage ��

        if(Monster_hp <= 0)                                 // ���� Moster hp�� 0�� �Ǹ�
        {
            GameObject temp = this.gameObject;              // �� �ڽ��� temp�� �Է�
            Destroy(temp);                                  // temp�� �ı� -> �ڽ��� �ı�
        }
    }
}
