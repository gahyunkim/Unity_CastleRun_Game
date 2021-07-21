using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   //씬 이동을 위한 부분

public class GameOver2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))   //엔터를 누르면 실행되는 부분
        {
            SceneManager.LoadScene("Stage2");  //엔터를 누르면 Stage1으로 이동한다.
            Score.coinAmount = 0;    //엔터를 누르면 Score스크립트에서 coinAmount를 0으로 초기화해준다.
        }
    }
}
