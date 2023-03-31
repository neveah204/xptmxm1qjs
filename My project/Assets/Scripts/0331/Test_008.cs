using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player                                     // 플레이어 클래스를 생성함. 플레이어는 아래에 변수값 (능력치)를 가짐
{
    private int hp = 100;                               //변수 'hp'를 Private int로 선언하고 100입력
    private int Power = 50;                             // Power 값은 50을 부여함. 즉 플레이어는 hp 100과 power 50을 가짐

    public void Attack()                                // 메소드 Attack 생성
    {
        Debug.Log(this.Power + " 데미지를 입혔다.");           // power값을(현재 플레이어의 power값은 50) 문자와 함께 출력
    }

    public void Damage(int Damage)                      // 메소드 Damage 생성
    {
        this.hp -= Damage;                              // Hp를 Damage만큼 뺀다
        Debug.Log(Damage + " 데미지를 입었다.");          // 그 후 로그에 입은 데미지를 문자와 함께 출력
    }

    public int Gethp()                                  // 정수 Gethp를 "공용으로" (Public) 생성
    {
        return hp;                                      // return 값은 Hp임
    }
}

public class Test_008 : MonoBehaviour
{
    public Text PlayerHp;                           // playerhp Text를 공용으로 생성 (UI)
    public Text Player2Hp;                           // Text를 생성하고 Playerhp로 지정한 것과 같다

    Player mPlayer = new Player();                  // mPlayer를 생성 및 Player 클래스를 지정
    Player mPlayer2 = new Player();                  // mPlayer2를 생성 및 Player 클래스를 지정


    // Start is called before the first frame update
    void Start()
    {

        //mPlayer.Attack();                               // 메소드 Attack를 Player에게 실행시킴 (50)
        //mPlayer.Damage(30);                             // 플레이어에게 메소드를 실행하여, 데미지 30부여
        //Debug.Log(mPlayer.Gethp());                     // 플레이어의 HP값을 로그에 출력
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHp.text = "Player1 HP : " + mPlayer.Gethp().ToString();      //Player의 HP를 UI로 (playerhp.text) 표시
        Player2Hp.text = "Player2 HP : " + mPlayer2.Gethp().ToString();    // "Playerhp.text"는 문자열 ("Player2 HP : ")에 플레이어 Hp값 (gethp) 를 문자로 입력함

        if (Input.GetMouseButtonDown(0))                                        // 왼쪽 마우스 입력시 Player1이
            mPlayer.Damage(1);                                                  // 피해 1을 받는다

        if (Input.GetMouseButtonDown(1))                                        // 오른쪽 마우스 입력시 Player2가
            mPlayer2.Damage(1);                                                 // 피해 1을 받는다
    }
}
