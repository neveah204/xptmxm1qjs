using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;                     //int = ���� answer�� ������
        answer = 1 + 2;
        Debug.Log(answer);

        int n1 = 8;                     //int n1�� ���� �ϰ� �� �Է�
        int n2 = 9;
        int answer2;
        answer2 = n1 + n2;
        Debug.Log(answer2);

        int answer3 = 10;               // answer3�� ����� ���� ������
        answer3 += 5;                   // += �� ���� ���� n (5)�� ���� (answer3 += 5)
        Debug.Log(answer3);
        answer3++;                      // ++ �� 1�� ���ϴ� ��ɾ�
        Debug.Log(answer3);

        string str = "Happy ";          // ���� �� string���� str �����ϰ� ����
        string str2 = "birthday";

        str += str2;                    // ���ڿ��� +=�� �ַ� ������
        Debug.Log(str);

        string messege = str + answer3;         // ���ڿ� messege �����ϰ� ������
        Debug.Log(messege);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
