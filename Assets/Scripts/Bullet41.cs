using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //체력바를 사용하기 위해 UI사용
using UnityEngine.SceneManagement;   //씬이동을 위한 부분

public class Bullet41 : MonoBehaviour
{
    Rigidbody2D rbComp;    //Rigidbody2D를 선언해준다.

    void Start()
    {
        rbComp = GetComponent<Rigidbody2D>();   //rigidBody로 선언해준 캐릭터를 사용하기 위해서 사용
    }


    void Update()
    {
        rbComp.AddForce(new Vector2(6, 0));  // 총알이 발사되는 방향을 정해주고 힘을 가함
    }

    private void OnTriggerEnter2D(Collider2D collision)   //충돌을 관리하는 부분
    {
        if (collision.name.Contains("Princess"))   //공주와 충돌하는 경우
        {
            Health.health -= 30.0f; // 공주와 충돌시에 체력이 30씩 감소할 수 있도록 설정함

            if (Health.health <= 0)  // 만약 공주의 체력이 0과 같거나 작아지는 경우 3GameOver로 씬이 이동한다.
            {
                SceneManager.LoadScene("3GameOver");
            }
            Destroy(gameObject);   //충돌하면 게임오브젝트인 총알을 없애라.
        }
    }
}
