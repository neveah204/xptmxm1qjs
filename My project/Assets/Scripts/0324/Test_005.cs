using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // CTRL + K + C = ��ü �ּ�, CTRL + K + U = ��ü �ּ� ����

        //for (int I = 0; I < 5; I++)             // '0' ���� '4'���� "1�� ����"  ++ �� 1�� ����
        //    Debug.Log(I);
        //for (int I = 0; I < 10; I += 2)         // '0' ���� '10'���� '2'�� ����'  += �� N��ŭ ����
        //    Debug.Log(I);
        //for (int i = 3; i > 0; i--)             // '3'���� '0'���� '1' �� ����'  -- �� 1�� ����
        //    Debug.Log(i);

        for (int i = 0; i < 10; i++)              // '0' ���� '10' ���� '1�� ����'
            if (i % 2 == 0)                       // '%' �� ������ ��
                Debug.Log(i);



        int sum = 0;                                // Sum �� ����, 0 ����
        for (int i = 0; i < 10; i++)                // '1' ���� '10'���� '1�� ����'
            sum += i;                               // sum�� 'i ��ŭ ����' (+=)
        Debug.Log(sum);



        for (int i = 0; i < 10; i++)                // int 'i'�� '0' ���� '10'���� '1�� ����'
            for (int j = 0; j < 10; j++)            // int 'j'�� '0' ���� '10'���� '1�� ����' 
                Debug.Log(i.ToString() + " X " + j.ToString() + " = " + (i * j).ToString());
        // int 'i'�� int 'j' �� ���Ͽ�, ���� 'X' �� '='�� ���� 'Log' �� ���. Tostring �� ������ ���ڷ� �ٲٴ� ��ɾ�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
