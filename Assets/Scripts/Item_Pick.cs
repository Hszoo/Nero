using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Pick : MonoBehaviour
{
    public bool itemFlag; //���������� �ƴ��� �Ǵ�
    public bool pick; //�������� ȹ���ߴ��� �Ǵ�
    GameObject obj; //������ �ִ� ������Ʈ
    GameObject item; //������ ������Ʈ

    void Start()
    {
        itemFlag = false;
        pick = false;
        obj = GameObject.FindWithTag("GetItem");
        item = GameObject.FindWithTag("Item");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("�����ۿ� ����");
            itemFlag = true;
        }
    }

    void Update()
    {
        if (itemFlag && (Input.touchCount > 0))
        {
            Debug.Log("�����ۿ� ȹ��");
            //Destroy(gameObject);
            gameObject.SetActive(false);
            pick = true;
        }
    }

    //test code
    private void OnMouseDown()
    {
        if (itemFlag)
        {
            Debug.Log("�����ۿ� ȹ��");
            //Destroy(gameObject);
            gameObject.SetActive(false);
            pick = true;
            itemFlag = false;
        }
    }
}
