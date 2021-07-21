﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   //씬 이동을 위한 부분

public class People3 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)  //충돌을 관리하는 부분
    {
        SceneManager.LoadScene("GameClear");  //충돌하면 GameClear씬으로 이동한다.
        Score.coinAmount = 0;   //충돌하면 저장되어있던 값을 0으로 초기화시킨다.
    }
}
