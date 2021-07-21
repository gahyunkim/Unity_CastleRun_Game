using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    GameObject curObj;  //게임오브젝트를 선언해줌
    GameObject curObj2;   //게임오브젝트를 선언해줌

    public AudioClip clip1;  //AudioClip을 불러오기 위한 부분
    AudioSource audioSrc;  //AudioSource를 사용하기 위해 선언해줌

    private float TimeLeft = 2.0f;  //시간이 2초 남아있는 것을 보여줌
    private float nextTime = 0.0f;   //남은 시간이 0초임을 알려줌

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();  //AudioSource를 사용할 수 있도록 불러오는 부분
    }

    void Update()
    {
        if (Time.time > nextTime)  //만약 시간이 남은 시간보다 크다면
        {
            nextTime = Time.time + TimeLeft;   //다음 시간은 현재 진행된 시간에 남은 시간을 더해준다.
            curObj = GameObject.Find("Bullet");   //게임 오브젝트인 Bullet을 찾는다.
            curObj2 = GameObject.Find("Bullet2");   //게임 오브젝트인 Bullet2를 찾는다.
            audioSrc.PlayOneShot(clip1, 0.5f);      //시간에 맞추어 clip1을 0.5초동안 출력하는 부분
            GameObject newObj = Instantiate(curObj, transform.position, Quaternion.identity);    // Instantiate를 이용해서 복제하여 복제된 총알이 발사될 수 있게 한다.
            GameObject newObj2 = Instantiate(curObj2, transform.position, Quaternion.identity);  // Instantiate를 이용해서 복제하여 복제된 총알이 발사될 수 있게 한다.
            Destroy(newObj, 1f);  //생성된지 1초 후에 복제된 총알이 사라질 수 있도록 한다.
            Destroy(newObj2, 1f);  //생성된지 1초 후에 복제된 총알이 사라질 수 있도록 한다.
        }
    }

}
