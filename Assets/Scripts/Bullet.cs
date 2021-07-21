using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //Health 체력바의 움직임을 사용하기 위함
using UnityEngine.SceneManagement;   //씬 이동을 위해 사용하는 부분

public class Bullet : MonoBehaviour
{
    Rigidbody2D rbComp;   //Rigidbody2D를 선언해준다.

    void Start()
    {
        rbComp = GetComponent<Rigidbody2D>();    //rigidBody로 선언해준 캐릭터를 사용하기 위해서 사용
    }

    // Update is called once per frame
    void Update()
    {
        rbComp.AddForce(new Vector2(-6, 0));  // 총알이 발사되는 방향을 정해주고 힘을 가함
    }

    private void OnTriggerEnter2D(Collider2D collision)   //충돌을 처리하는 부분
    {
        if (collision.name.Contains("Princess"))   //공주와 충돌하는 경우
        {
            Health.health -= 30.0f; //충돌시에 체력아 30씩 줄어든다.

            if (Health.health <= 0)  //Helath가 0과 같거나 작을때 3GameOver로 이동할 수 있도록 함
            {
                SceneManager.LoadScene("3GameOver");
            }
            Destroy(gameObject);  //충돌하면 총알을 없앤다.
        }
            
    }
}
