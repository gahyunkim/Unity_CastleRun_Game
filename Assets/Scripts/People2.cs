using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //씬을 이동하는 부분

public class People2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //충돌을 관리하는 부분
    {
        SceneManager.LoadScene("Stage3");   //충돌하면 스테이지3로 이동한다. 
        Score.coinAmount = 0;    //충돌하면 코인에 저장되어있던 값을 0으로 초기화시킨다.
    }
}
