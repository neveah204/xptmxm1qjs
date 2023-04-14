using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 LaunchDirection;             //발사체 방향성 선언

    private void FixedUpdate()
    {
        float MoveAmount = 3 * Time.fixedDeltaTime;         // 발사체 이동 속도
        transform.Translate(LaunchDirection * MoveAmount);  // 해당 방향으로 이동
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);               // 충돌 대상 이름을 로그에 출력
        if(collision.gameObject.name == "wall")             // 만약 충돌 대상이 Wall이면
        {
            GameObject temp = this.gameObject;              // 나 자신을 temp에 입력
            Destroy(temp);                                  // temp를 파괴 -> 자신을 파괴
        }

        if (collision.gameObject.name == "Moster")             // 만약 충돌 대상이 Moster이면
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;              // 나 자신을 temp에 입력
            Destroy(temp);                                  // temp를 파괴 -> 자신을 파괴
        }
    }
}
