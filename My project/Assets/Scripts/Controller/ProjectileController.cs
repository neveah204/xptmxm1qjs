using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 LaunchDirection;                             // �߻� ���� launchDirection ����
    public GameObject Projectile;                               // ���� ������Ʈ projectile ����

    public void FireProjectile()
    {
        GameObject temp = (GameObject)Instantiate(Projectile);      // �߻�ü ������ ���� �� temp�� �Է� , Instantiate -> ���� ������Ʈ, �������� ����

        temp.transform.position = this.gameObject.transform.position;

        temp.GetComponent<ProjectileMove>().LaunchDirection = transform.forward;

        Destroy(temp, 10f);             // 10�� �� �߻�ü ����


    }



}
