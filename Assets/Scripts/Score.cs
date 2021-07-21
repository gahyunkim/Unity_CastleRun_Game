using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //체력바를 사용하기 위한 부분

public class Score : MonoBehaviour
{
    Text text; //캔버스에서 사용하는 text를 사용하기 위한 부분
    public static int coinAmount;  //static으로 사용하여 외부에서도 접근할 수 있도록 함, coin의 값을 설정하는 부분

    void Start()
    {
        text = GetComponent<Text>();  //캔버스에서 text를 사용할 수 있도록 불러오는 부분
    }

    void Update()
    {
        text.text = coinAmount.ToString();  //ToString을 통해서 정수인 값을 문자로 바꿔 보여주게 된다. 
    }
}
