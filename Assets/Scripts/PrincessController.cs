using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessController : MonoBehaviour
{
    Rigidbody2D rigid2D;     //rigidbody2D를 사용하기 위해 선언
    Animator animator;   //애니메이션을 사용하기 위한 부분
    public AudioClip clip1;  //AudioClip을 사용하기 위해 선언함
    AudioSource audioSrc;   //Audio를 사용하기 위해 선언함
    float jumpForce = 480.0f;  //점프할때의 힘
    float walkForce = 30.0f;     //걸어갈떄의 힘
    float maxWalkSpeed = 2.0f;   //최대 걸음의 속도

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();  //AudioSource를 사용하기 위한 부분
        this.animator = GetComponent<Animator>();   //공주가 오른쪽 왼쪽으로 이동할때 애니메이션을 사용하기 위한 부분
        this.rigid2D = GetComponent<Rigidbody2D>();  //공주가 사용하는 rigidbody를 사용하기 위한 부분
    }

    // Update is called once per frame
    void Update()
    {
        //점프한다
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            //스페이스바를 누르면 점프하고 두번 누르는 것을 허용하지 않기 위한 부분
            audioSrc.PlayOneShot(clip1, 0.5f);   // 스페이스바를 누르면 점프하는 오디오를 사용하는 부분
            this.rigid2D.AddForce(transform.up * this.jumpForce);  //jumpforce를 이용해서 스페이스바를 누르면 지정된 힘으로 점프할 수 있도록 함
        }

        //좌우로 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow))  //오른쪽 화살표를 누를 때 사용하는 부분 
        {
            this.animator.SetTrigger("rightArrow");  //오른쪽 화살표를 누르면 만들어놓은 오른쪽으로 이동하는 공주의 애니메이션을 사용한다.
            key = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //오른쪽 화살표를 누를 때 사용하는 부분 
        {
            this.animator.SetTrigger("leftArrow");  //왼쪽 화살표를 누르면 만들어놓은 왼쪽으로 이동하는 공주의 애니메이션을 사용한다.
            key = -1;
        }

        //플레이어 속도
        float speedx = Mathf.Abs(rigid2D.velocity.x);   //플레이어의 속도를 설정하는 부분

        //스피드 제한
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce); //어떤 키를 눌렀는지에 따라 힘의 방향을 다르게 하여 오른쪽 화살표키를 눌렀으면 오른쪽으로 힘만큼 이동할 수 있도록 함
        }

        if (this.rigid2D.velocity.x == 0)
        {
            this.animator.speed = speedx / 2.0f;  //애니메이터의 스피드를 조절하는 부분
        }
        else
        {
            this.animator.speed = 1.0f;  //애니메이터의 속도를 1로 지정
        }
    }

}
