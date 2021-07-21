using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio2 : MonoBehaviour
{
    public AudioClip clip1;   //AudioClip을 이용해서 Audio를 가져올 수 있도록 함
    AudioSource audioSrc;    //AudioSource로 오디오를 사용하고 오디오의 상세한 조절이 가능함.

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();  //음악소스를 가져오기 위한 방법
    }

    // Update is called once per frame
    void Update()
    {

    }
}
