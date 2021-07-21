using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //체력바를 이용하기 위한 부분
using UnityEngine.SceneManagement;   //씬 이동을 위한 부분

public class Delphinew : MonoBehaviour
{

    Vector3 pos; //현재위치

    float delta = 0.5f; // 좌우로 이동이 가능한 x의 최대값
    float speed = 2.0f; // 이동속도


    void Start()
    {
        pos = transform.position;  //현재위치를 가져오는 문장

    }

    void Update()
    {
        Vector3 v = pos;  
        v.x += delta * Mathf.Sin(Time.time * speed);
        //Mathf.Sin은 sin,cos할때 사용하는 그 sin이고 sin그래프는 1과 -1을 반복하기 때문에 이를 이용해서 좌우로 반복운동할 수 있도록 함
        //TIme.time은 개임을 시작하고 나서 프레임이 시작한 시간을 말함
        //Time.time과 Mathf.Sin을 이용해서 어떤 delta값을 입력해도 Sin은 -1과 1만 반환하기 때문에 곱하면 +,-로 계속 반전되기 때문에 좌우로 이동할 수 있게 된다.
        transform.position = v;
    }

    private void OnTriggerEnter2D(Collider2D collision)  //충돌관리
    {
        if (collision.name.Contains("Princess"))  //Princess와 충돌한다면
        {
            Health.health -=80.0f; // 체력바가 100에서 20으로 되도록 설정 (-80)

            if (Health.health <= 0)  // Helath가 0과 같거나 작을때 3GameOver로 이동할 수 있도록 함
            {
                SceneManager.LoadScene("3GameOver");
            }
        }
    }
}
