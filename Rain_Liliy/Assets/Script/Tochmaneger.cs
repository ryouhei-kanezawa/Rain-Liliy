using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tochmaneger : MonoBehaviour
{
    [SerializeField]
    private MakeBook _book;
    private List<GameObject> Books = new List<GameObject>();
    private GameObject lastBook;

    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
            //Debug.Log("�ŏ�");
            FirstBook();
		}

		if (Input.GetMouseButton(0) && Books.Count > 0)
        {
            //Debug.Log("��");
            Dragging();
		}

		if (Input.GetMouseButtonUp(0))
        {
            //Debug.Log("����");
            DeleteBooks();
		}
    }

    void FirstBook()
    {
        GameObject _child;
        RaycastHit2D hit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 0.5f);
        if (hit2D.collider != null)
        {
            if(hit2D.collider.gameObject.CompareTag("���s�[�X")|| hit2D.collider.gameObject.CompareTag("�΃s�[�X")
                || hit2D.collider.gameObject.CompareTag("�s�[�X")|| hit2D.collider.gameObject.CompareTag("�ԃs�[�X")
                || hit2D.collider.gameObject.CompareTag("���s�[�X"))
            {
                var thisBook = hit2D.collider.gameObject;
                _child = thisBook.transform.GetChild(0).gameObject;
                Books.Add(thisBook);
                Color bookColor = _child.GetComponent<SpriteRenderer>().color;
                bookColor.a = 0.5f;
                _child.GetComponent<SpriteRenderer>().color = bookColor;
                lastBook = thisBook;
            }
        }
    }

    void Dragging()
	{
        GameObject _child;
        RaycastHit2D hit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 0.5f);
        Debug.Log("�ړ���");
        if (hit2D.collider != null)
        {
            Debug.Log("1");
            if (hit2D.collider.gameObject.tag==lastBook.tag)
            {
                Debug.Log("2");
                var thisBook = hit2D.collider.gameObject;

                Vector2 distance = thisBook.transform.position - lastBook.transform.position;

				if (!Books.Contains(thisBook) && distance.magnitude <= 20.0f)
				{
                    Debug.Log("�ǉ�");
                    _child = thisBook.transform.GetChild(0).gameObject;
                    Books.Add(thisBook);
                    Color bookColor = _child.GetComponent<SpriteRenderer>().color;
                    bookColor.a = 0.5f;
                    _child.GetComponent<SpriteRenderer>().color = bookColor;
                    lastBook = thisBook;
                }
                
            }
        }
    }

    void DeleteBooks()
	{
		if (Books.Count >= 3)
		{
            foreach(var item in Books)
			{
                Debug.Log("�폜��");
                Destroy(item);
			}
            _book.NewPeas(Books.Count);
		}
		else
		{
            Debug.Log("�폜���Ȃ�");
            GameObject _child;
            foreach(var item in Books)
			{
                _child = item.transform.GetChild(0).gameObject;
                Color bookColor = _child.GetComponent<SpriteRenderer>().color;
                bookColor.a = 1;
                _child.GetComponent<SpriteRenderer>().color = bookColor;
            }
		}
        Books.Clear();
	}
}
