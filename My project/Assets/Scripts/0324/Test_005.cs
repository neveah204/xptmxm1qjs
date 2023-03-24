using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // CTRL + K + C = 전체 주석, CTRL + K + U = 전체 주석 해제

        //for (int I = 0; I < 5; I++)             // '0' 에서 '4'까지 "1씩 증가"  ++ 는 1씩 증가
        //    Debug.Log(I);
        //for (int I = 0; I < 10; I += 2)         // '0' 에서 '10'까지 '2'씩 증가'  += 는 N만큼 증가
        //    Debug.Log(I);
        //for (int i = 3; i > 0; i--)             // '3'에서 '0'까지 '1' 씩 감소'  -- 는 1씩 감소
        //    Debug.Log(i);

        for (int i = 0; i < 10; i++)              // '0' 부터 '10' 까지 '1씩 증가'
            if (i % 2 == 0)                       // '%' 는 나머지 값
                Debug.Log(i);



        int sum = 0;                                // Sum 을 생성, 0 지정
        for (int i = 0; i < 10; i++)                // '1' 에서 '10'까지 '1씩 증가'
            sum += i;                               // sum을 'i 만큼 증가' (+=)
        Debug.Log(sum);



        for (int i = 0; i < 10; i++)                // int 'i'를 '0' 에서 '10'까지 '1씩 증가'
            for (int j = 0; j < 10; j++)            // int 'j'를 '0' 에서 '10'까지 '1씩 증가' 
                Debug.Log(i.ToString() + " X " + j.ToString() + " = " + (i * j).ToString());
        // int 'i'를 int 'j' 와 곱하여, 글자 'X' 와 '='를 붙혀 'Log' 로 출력. Tostring 은 정수를 문자로 바꾸는 명령어.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
