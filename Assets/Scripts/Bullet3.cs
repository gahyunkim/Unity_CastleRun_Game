using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet3 : MonoBehaviour
{
    Rigidbody2D rbComp;  //Rigidbody2D를 선언해준다.

    void Start()
    {
        rbComp = GetComponent<Rigidbody2D>();   //rigidBody로 선언해준 캐릭터를 사용하기 위해서 사용
    }


    void Update()
    {
        rbComp.AddForce(new Vector2(4, 0));  // 총알이 발사되는 방향을 정해주고 힘을 가함
    }

}
