using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour  //코인 소리 출력을 위한 스크립트
{
    static AudioSource audioSource;   //AudioSource를 사용하기 위해 선언해줌
    public static AudioClip audioClip;  //AudioClip을 불러오기 위한 부분

    void Start()
    {
        audioSource = GetComponent<AudioSource>();   //AudioSource를 사용할 수 있도록 불러오는 부분
        audioClip = Resources.Load<AudioClip>("Coin");  //Resources에 있는 Coin 오디오 소스를 이용하기 위한 부분
    }

    public static void SoundPlay()  //다른 스크립트에서 호출할 수 있도록 static사용함.
    {
        audioSource.PlayOneShot(audioClip);  //audioClip에서 불러온 오디오를 출력될 수 있도록 하는 부분
    }

}
