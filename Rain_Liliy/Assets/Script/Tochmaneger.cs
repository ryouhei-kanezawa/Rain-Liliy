using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tochmaneger : MonoBehaviour
{
    private GameObject[] listOfBooks;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void FirstBook()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 0.5f);
        if (hit2D.collider != null)
        {
            if(hit2D.collider.gameObject.CompareTag("紫ピース")|| hit2D.collider.gameObject.CompareTag("緑ピース")
                || hit2D.collider.gameObject.CompareTag("青ピース")|| hit2D.collider.gameObject.CompareTag("赤ピース")
                || hit2D.collider.gameObject.CompareTag("黄ピース"))
            {
                var thisBook = hit2D.collider.gameObject;
            }
        }
    }
}
