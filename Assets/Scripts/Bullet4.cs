using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bullet4 : MonoBehaviour
{
    Rigidbody2D rbComp;  //Rigidbody2D를 선언해준다.

    void Start()
    {
        rbComp = GetComponent<Rigidbody2D>();  //rigidBody로 선언해준 캐릭터를 사용하기 위해서 사용
    }


    void Update()
    {
        rbComp.AddForce(new Vector2(6, 0));  // 총알이 발사되는 방향을 정해주고 힘을 가함
    }

    private void OnTriggerEnter2D(Collider2D collision)   //충돌관리를 위한 부분
    {
        if (collision.name.Contains("Princess"))   //공주와 충돌하는 경우
        {
            Health.health -= 30.0f; // 총알과 공주가 충돌시에 체력이 30씩 줄어듬

            if (Health.health <= 0)  // 만약 공주의 체력이 0과 같거나 작아지는 경우 1GameOver로 씬이 이동한다.
            {
                SceneManager.LoadScene("1GameOver");
            }
            Destroy(gameObject);  //충돌하면 총알을 없앤다.
        }
    }
}
