using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour   //카메라의 이동을 관여하는 스크립트
{
    GameObject player;  // 게임 오브젝트를 선언해준다.

    void Start()
    {
        this.player = GameObject.Find("Princess");  //공주 오브젝트를 찾는다.
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;    //PlayerPos를 이용해서 현재 공주 오브젝트의 위치가 어디인지를 확인한다.
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
        //y의 위치로만 이동할 것이므로 x와 z위치는 고정시키고 x만 이동할 수있도록 설정해준다.
    }
}
