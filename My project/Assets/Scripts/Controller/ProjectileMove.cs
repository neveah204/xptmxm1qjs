using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 LaunchDirection;             //�߻�ü ���⼺ ����

    private void FixedUpdate()
    {
        float MoveAmount = 3 * Time.fixedDeltaTime;         // �߻�ü �̵� �ӵ�
        transform.Translate(LaunchDirection * MoveAmount);  // �ش� �������� �̵�
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);               // �浹 ��� �̸��� �α׿� ���
        if(collision.gameObject.name == "wall")             // ���� �浹 ����� Wall�̸�
        {
            GameObject temp = this.gameObject;              // �� �ڽ��� temp�� �Է�
            Destroy(temp);                                  // temp�� �ı� -> �ڽ��� �ı�
        }

        if (collision.gameObject.name == "Moster")             // ���� �浹 ����� Moster�̸�
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;              // �� �ڽ��� temp�� �Է�
            Destroy(temp);                                  // temp�� �ı� -> �ڽ��� �ı�
        }
    }
}
