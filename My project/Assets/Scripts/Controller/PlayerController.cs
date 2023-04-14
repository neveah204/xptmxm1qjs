using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movespeed = 1.0f;                          // 이동속도 변수
    public GameObject playerPivot;                          // 게임 오브젝트 플레이어 피봇 선언
    Camera viewcamera;                                      // 카메라 viewcamera 선언
    Vector3 velocity;                                       // 벡터 값 velocity 선언
    public ProjectileController projectileController;       // 발사체 컨트롤 접근

    // Start is called before the first frame update
    void Start()
    {
        viewcamera = Camera.main;                           // 메인 카메라를 viewcamera에 입력
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = viewcamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewcamera.transform.position.y));
        // 모니터 2D -> 인게임 3D로 좌표 변환 (마우스 위치)

        Vector3 targetposition = new Vector3(mousePos.x, transform.position.y, mousePos.z);
        // 바라볼 위치를 계산하기 위해 y 축 좌표 설정 ( 바닥은 x, z 축임)

        playerPivot.transform.LookAt(targetposition, Vector3.up);
        // 받은 피봇이 마우스를 보게 한다

        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * movespeed;
        // w, a ,s ,d 화살표 OR 지원할 이동도구 입력. Horizontal , Vertical 은 첫 글자가 대문자여야 함

        if(Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);
        // Getcomponent -> 소스가 있는 게임  오브젝트에서 <> 안에 있는 컴퍼넌트에 접근
        // 그 후 계산된 위치 값을 moveposition에 적용
    }
}
