using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;
    public Text textUI;
    public Text hpTextUI;

    // Start is called before the first frame update
    void Start()
    {
                    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            hp += 10;
        if (Input.GetMouseButtonDown(1))
            hp -= 10;



        if (hp <= 50)
            textUI.text = "도망";
        //Debug.Log("도망");
        else if (hp >= 200)
            textUI.text = "공격";
        //Debug.Log("공격");
        else
            textUI.text = "방어";
        //Debug.Log("방어");

        hpTextUI.text = "HP : " + hp.ToString();            //Tostring = 정수를 문자로 변환 (HP -> 숫자)
    }

   
}
