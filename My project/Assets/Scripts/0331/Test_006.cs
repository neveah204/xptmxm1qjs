using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    public int[] array = new int[5];                //"�迭" 5���� ���� �� �̸��� "array"�� ����
    public int[] points = {83, 99, 52, 93, 15};
    // Start is called before the first frame update
    void Start()
    {
        array[0] = 2;                               // ������ "�迭"�� ���� ����
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)                 // array �迭 0~4������ ����, �α׷� ���
            Debug.Log(array[i]);

        Debug.Log("--------------");

        for (int i = 0; i < points.Length; i++)          //�迭�� "����"�� �����´�. = 5
            if (points[i] > 90)                          // 90�� �Ѵ� "����Ʈ �迭�� �� 'n'��", �α׿� ��� 
                Debug.Log(points[i]);

        int sum = 0;                                       //int sum ����

        for (int i = 0; i < points.Length; i++)             
            sum += points[i];                               // point ���� ��� ����

        int average = sum / points.Length;                  // point�� ���� ����(sum) point �迭 ������ŭ(5) ������

        Debug.Log(average);
    }
}
