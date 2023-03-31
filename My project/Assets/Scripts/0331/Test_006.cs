using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    public int[] array = new int[5];                //"배열" 5개를 선언 및 이름을 "array"로 지정
    public int[] points = {83, 99, 52, 93, 15};
    // Start is called before the first frame update
    void Start()
    {
        array[0] = 2;                               // 지정된 "배열"에 정수 지정
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)                 // array 배열 0~4까지의 값을, 로그로 출력
            Debug.Log(array[i]);

        Debug.Log("--------------");

        for (int i = 0; i < points.Length; i++)          //배열의 "길이"를 가져온다. = 5
            if (points[i] > 90)                          // 90이 넘는 "포인트 배열에 값 'n'을", 로그에 출력 
                Debug.Log(points[i]);

        int sum = 0;                                       //int sum 생성

        for (int i = 0; i < points.Length; i++)             
            sum += points[i];                               // point 값을 모두 더함

        int average = sum / points.Length;                  // point의 합한 값을(sum) point 배열 개수만큼(5) 나눈다

        Debug.Log(average);
    }
}
