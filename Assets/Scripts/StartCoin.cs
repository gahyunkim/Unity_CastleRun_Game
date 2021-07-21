using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)  //충돌을 관리하는 부분
    {
        Destroy(gameObject);  //코인과 충돌하면 사라지게 만든다.
        Sfx.SoundPlay();   //코인과 충돌하면 코인사운드를 출력할 수 있도록 하는 부분
    }
}
