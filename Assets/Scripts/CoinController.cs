using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour   //코인에 관여하는 스크립트
{
    private void OnTriggerEnter2D(Collider2D collision)   //충돌 관리를 하는 부분
    {
        if (collision.name.Contains("Princess"))  //공주와 충돌한다면 실행되는 부분
        {
            Score.coinAmount += 5;   //코인을 하나 먹을 때 마다 Score스크립트에 있는 coinAmount의 값이 5씩 올라간다.
            Destroy(gameObject);     //코인과 충돌하면 충돌한 코인을 없앤다.
            Sfx.SoundPlay();         //Sfx스크립트에 있는 SoundPlay()함수를 호출하여 코인 소리를 출력한다.
        }
    }
}
