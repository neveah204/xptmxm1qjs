using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void Sayhello()                             //�μ��� ���� �޼���
    {
        Debug.Log("=======");
        Debug.Log("hello");
        Debug.Log("=======");
    }

    void Callname(string name)                  //�μ� "���� name"�� �ִ� �޼���
    {
        Debug.Log("hello" + name);
    }

    int add(int a, int b)                       //�μ��� ��ȯ���� �ִ� �޼���
    {
        int c = a + b;
        return c;                               // return�� ����� �Ͱ� ���� ���ڿ�����, int = return int
    }
    void Start()
    {
        Callname("Tom");
        Callname("Harry");
        Callname("Lora");

        int answer;
        answer = add(2, 3);                     //�޼��� add�� 2, 3�� ����, return�� answer �Է�
        Debug.Log(answer);
        Debug.Log(add(7, 9));                   // �Լ���(2, 3) ������(int answer)�� ���� �ʰ� �α׷� ��� ����
    }
}
