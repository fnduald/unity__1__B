using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExMouseButton : MonoBehaviour
{
    public int Hp = 100;
    public Text textUI;
   

    void Update() //매 프레임마다 호출 한다 
    {
       
        if (Input.GetMouseButtonDown(0)) //마우스 입력이 들어올때
        {
            textUI.text = "체력 :" + Hp.ToString();
           
            Hp -= 10;
           // Debug.Log("체력: " + Hp);
            if(Hp<=0) //체력이 0이하로 내려가면 게임 오브젝트를 파괴 한다 
            {
            textUI.text = "체력 :" + Hp.ToString();

                Destroy(gameObject);
            }
        }

    }
}
