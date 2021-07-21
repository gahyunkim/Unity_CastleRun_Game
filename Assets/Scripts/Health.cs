using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //체력바 사용을 위한 부분

public class Health : MonoBehaviour
{
    float maxHealth = 100f; //Player의 체력을 100으로 정해줌
    public static float health; // health를 static으로 설정하여 외부에서 접근할 수 있도록 해줌
    public Image imgComp; // 체력바를 Canvas내부 Image로 생성해주었으므로 이를 선언해줌
   
    void Start()
    {
        health = maxHealth; // maxHealth를 health로 대입하여 값을 정해줌
    }
    void Update()
    {
        imgComp.fillAmount = health / maxHealth;  //fillAmount를 사용해서 체력바가 점점 소모되도록 해줌
    }
}
