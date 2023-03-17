using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;                     //int = 정수 answer를 생성함
        answer = 1 + 2;
        Debug.Log(answer);

        int n1 = 8;                     //int n1을 생성 하고 값 입력
        int n2 = 9;
        int answer2;
        answer2 = n1 + n2;
        Debug.Log(answer2);

        int answer3 = 10;               // answer3를 만들고 값을 지정함
        answer3 += 5;                   // += 는 앞의 값에 n (5)를 더함 (answer3 += 5)
        Debug.Log(answer3);
        answer3++;                      // ++ 는 1을 더하는 명령어
        Debug.Log(answer3);

        string str = "Happy ";          // 문자 값 string으로 str 생성하고 지정
        string str2 = "birthday";

        str += str2;                    // 문자열은 +=로 주로 병함함
        Debug.Log(str);

        string messege = str + answer3;         // 문자열 messege 생성하고 더했음
        Debug.Log(messege);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
