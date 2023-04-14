using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_hp = 5;                              // 정수 Monster_hp 를 생성 및 5로 선언

    public void Monster_Damaged(int damage)                 
    {
        Monster_hp -= damage;                               // Monster_hp 는 대미지를 받으면 - damage 값

        if(Monster_hp <= 0)                                 // 만약 Moster hp가 0이 되면
        {
            GameObject temp = this.gameObject;              // 나 자신을 temp에 입력
            Destroy(temp);                                  // temp를 파괴 -> 자신을 파괴
        }
    }
}
