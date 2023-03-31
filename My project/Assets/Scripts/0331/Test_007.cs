using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void Sayhello()                             //인수가 없는 메서드
    {
        Debug.Log("=======");
        Debug.Log("hello");
        Debug.Log("=======");
    }

    void Callname(string name)                  //인수 "문자 name"이 있는 메서드
    {
        Debug.Log("hello" + name);
    }

    int add(int a, int b)                       //인수와 반환값이 있는 메서드
    {
        int c = a + b;
        return c;                               // return은 선언된 것과 같은 문자여야함, int = return int
    }
    void Start()
    {
        Callname("Tom");
        Callname("Harry");
        Callname("Lora");

        int answer;
        answer = add(2, 3);                     //메서드 add에 2, 3을 지정, return에 answer 입력
        Debug.Log(answer);
        Debug.Log(add(7, 9));                   // 함수를(2, 3) 변수에(int answer)에 넣지 않고도 로그로 출력 가능
    }
}
