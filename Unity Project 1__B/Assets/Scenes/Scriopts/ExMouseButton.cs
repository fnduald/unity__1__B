using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExMouseButton : MonoBehaviour
{
    public int Hp = 100;
    public Text textUI;
   

    void Update() //�� �����Ӹ��� ȣ�� �Ѵ� 
    {
       
        if (Input.GetMouseButtonDown(0)) //���콺 �Է��� ���ö�
        {
            textUI.text = "ü�� :" + Hp.ToString();
           
            Hp -= 10;
           // Debug.Log("ü��: " + Hp);
            if(Hp<=0) //ü���� 0���Ϸ� �������� ���� ������Ʈ�� �ı� �Ѵ� 
            {
            textUI.text = "ü�� :" + Hp.ToString();

                Destroy(gameObject);
            }
        }

    }
}
