using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   //씬 이동을 위한 부분

public class People : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)  //충돌관리를 위한 부분
    {
        SceneManager.LoadScene("Stage2");  //갇혀있는 사람이 충돌하면 스테이지2로 이동함
        Score.coinAmount = 0;  //충돌하면 저장되어있던 값을 0으로 초기화한다.
    }
}
