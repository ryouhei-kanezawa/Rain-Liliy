using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum MaterialTag
{
	egg,
	potato,
	broccoli,
	carrot,
	tomato,
	lettuce,
	mushroom,
	bacon,
	meat,
	strawberry,
}

public class finished_nikujaga : MonoBehaviour
{
	[SerializeField]
	private Sprite finished_image;
	[SerializeField]
	private GameObject dish;
	[SerializeField]
	private Image m_Image;
	[SerializeField]
	MaterialTag[] m_tag;
	[SerializeField]
	private int[] order;

	private GameObject[] foodstuff;
	private bool phase1 = false;
	private int num=0;

	void Awake()
	{
		m_Image.sprite = finished_image;
		foreach(MaterialTag c_tag in m_tag)
		{
			Debug.Log(c_tag);
			if("egg"==c_tag.ToString())
			{
				Debug.Log("true");
			}else
			{ 
				Debug.Log("false");
			}
		}
	}

	void Update()
	{

	}

	private void Finished_order()
	{
		foreach (GameObject _stuff in foodstuff) 
		{

		}
	}
}
