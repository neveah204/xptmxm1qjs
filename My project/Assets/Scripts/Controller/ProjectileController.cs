using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 LaunchDirection;                             // 발사 방향 launchDirection 생성
    public GameObject Projectile;                               // 게임 오브젝트 projectile 선언

    public void FireProjectile()
    {
        GameObject temp = (GameObject)Instantiate(Projectile);      // 발사체 프리맵 생성 및 temp에 입력 , Instantiate -> 게임 오브젝트, 프리팹을 생성

        temp.transform.position = this.gameObject.transform.position;

        temp.GetComponent<ProjectileMove>().LaunchDirection = transform.forward;

        Destroy(temp, 10f);             // 10초 후 발사체 삭제


    }



}
