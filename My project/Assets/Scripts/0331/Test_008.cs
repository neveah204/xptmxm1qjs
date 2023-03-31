using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player                                     // �÷��̾� Ŭ������ ������. �÷��̾�� �Ʒ��� ������ (�ɷ�ġ)�� ����
{
    private int hp = 100;                               //���� 'hp'�� Private int�� �����ϰ� 100�Է�
    private int Power = 50;                             // Power ���� 50�� �ο���. �� �÷��̾�� hp 100�� power 50�� ����

    public void Attack()                                // �޼ҵ� Attack ����
    {
        Debug.Log(this.Power + " �������� ������.");           // power����(���� �÷��̾��� power���� 50) ���ڿ� �Բ� ���
    }

    public void Damage(int Damage)                      // �޼ҵ� Damage ����
    {
        this.hp -= Damage;                              // Hp�� Damage��ŭ ����
        Debug.Log(Damage + " �������� �Ծ���.");          // �� �� �α׿� ���� �������� ���ڿ� �Բ� ���
    }

    public int Gethp()                                  // ���� Gethp�� "��������" (Public) ����
    {
        return hp;                                      // return ���� Hp��
    }
}

public class Test_008 : MonoBehaviour
{
    public Text PlayerHp;                           // playerhp Text�� �������� ���� (UI)
    public Text Player2Hp;                           // Text�� �����ϰ� Playerhp�� ������ �Ͱ� ����

    Player mPlayer = new Player();                  // mPlayer�� ���� �� Player Ŭ������ ����
    Player mPlayer2 = new Player();                  // mPlayer2�� ���� �� Player Ŭ������ ����


    // Start is called before the first frame update
    void Start()
    {

        //mPlayer.Attack();                               // �޼ҵ� Attack�� Player���� �����Ŵ (50)
        //mPlayer.Damage(30);                             // �÷��̾�� �޼ҵ带 �����Ͽ�, ������ 30�ο�
        //Debug.Log(mPlayer.Gethp());                     // �÷��̾��� HP���� �α׿� ���
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHp.text = "Player1 HP : " + mPlayer.Gethp().ToString();      //Player�� HP�� UI�� (playerhp.text) ǥ��
        Player2Hp.text = "Player2 HP : " + mPlayer2.Gethp().ToString();    // "Playerhp.text"�� ���ڿ� ("Player2 HP : ")�� �÷��̾� Hp�� (gethp) �� ���ڷ� �Է���

        if (Input.GetMouseButtonDown(0))                                        // ���� ���콺 �Է½� Player1��
            mPlayer.Damage(1);                                                  // ���� 1�� �޴´�

        if (Input.GetMouseButtonDown(1))                                        // ������ ���콺 �Է½� Player2��
            mPlayer2.Damage(1);                                                 // ���� 1�� �޴´�
    }
}
