using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public DialogueManager manager;
    // public DialogueParser parser;
    /*
     
    �´� ������/�ൿ �� �ش� ��� ������ �Ѱܰ��ø� �˴ϴ�
        
     */

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            manager.Action("test");

        /*
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                GameObject clickObj = hit.collider.gameObject;
                Debug.Log(clickObj.name);
            }
        }
        */
    }
}
