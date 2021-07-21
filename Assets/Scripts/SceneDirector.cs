using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   //씬을 이동하는 부분

public class SceneDirector : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))  //엔터를 누르면 실행되는 부분
        {
            SceneManager.LoadScene("StartScene2");  //엔터를 누르면 StartScene2로 이동한다.
        }
    }
}
