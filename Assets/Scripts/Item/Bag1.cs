using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bag1 : MonoBehaviour
{
    public Boolean isBagOpen = false;

    public GameObject bagObj;
    public GameObject bagButton;
    public GameObject bag;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void BagState()
    {
        if (isBagOpen)  //���� �ݱ�
        {
            isBagOpen = false;
            bag.SetActive(false);
            Debug.Log("���� �ݱ�");
        }
        else    // ���� ����
        {
            isBagOpen = true;
            bag.SetActive(true);
            Debug.Log("���� ����");
        }
    }
}
