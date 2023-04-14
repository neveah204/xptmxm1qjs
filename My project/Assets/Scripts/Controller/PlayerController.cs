using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 1.0f;                          // �̵��ӵ� ����
    public GameObject playerPivot;                          // ���� ������Ʈ �÷��̾� �Ǻ� ����
    Camera viewcamera;                                      // ī�޶� viewcamera ����
    Vector3 velocity;                                       // ���� �� velocity ����
    public ProjectileController projectileController;       // �߻�ü ��Ʈ�� ����

    // Start is called before the first frame update
    void Start()
    {
        viewcamera = Camera.main;                           // ���� ī�޶� viewcamera�� �Է�
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = viewcamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewcamera.transform.position.y));
        // ����� 2D -> �ΰ��� 3D�� ��ǥ ��ȯ (���콺 ��ġ)

        Vector3 targetposition = new Vector3(mousePos.x, transform.position.y, mousePos.z);
        // �ٶ� ��ġ�� ����ϱ� ���� y �� ��ǥ ���� ( �ٴ��� x, z ����)

        playerPivot.transform.LookAt(targetposition, Vector3.up);
        // ���� �Ǻ��� ���콺�� ���� �Ѵ�

        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * movespeed;
        // w, a ,s ,d ȭ��ǥ OR ������ �̵����� �Է�. Horizontal , Vertical �� ù ���ڰ� �빮�ڿ��� ��

        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
        // Getcomponent -> �ҽ��� �ִ� ����  ������Ʈ���� <> �ȿ� �ִ� ���۳�Ʈ�� ����
        // �� �� ���� ��ġ ���� moveposition�� ����
    }
}
