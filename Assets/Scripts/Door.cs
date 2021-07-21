using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour  //사람들을 가둬놓은 문을 관리하는 스크립트
{
    private void OnTriggerEnter2D(Collider2D collision)  //충돌 관리하는 부분
    {
        Destroy(gameObject);  //충돌하면 없어진다.
    }
}
