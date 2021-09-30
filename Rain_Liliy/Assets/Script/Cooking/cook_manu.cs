using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class cook_manu : MonoBehaviour
{
	[Header("‹ïÞ")]
	[SerializeField]
	private GameObject egg;
	[SerializeField]
	private GameObject potato;
	[SerializeField]
	private GameObject broccoli;
	[SerializeField]
	private GameObject carrot;
	[SerializeField]
	private GameObject tomato;
	[SerializeField]
	private GameObject lettuce;
	[SerializeField]
	private GameObject mushroom;
	[SerializeField]
	private GameObject bacon;
	[SerializeField]
	private GameObject meat;
	[SerializeField]
	private GameObject parsley;
	[SerializeField]
	private GameObject crouton;
	[SerializeField]
	private GameObject cheese;
	[SerializeField]
	private GameObject dressing;
	[SerializeField]
	private GameObject sauce;

	[Space(5)]

	[Header("‹ïÞ‚Ìƒ{ƒ^ƒ“")]
	[SerializeField]
	private Button egg_bm;
	[SerializeField]
	private Button potato_bm;
	[SerializeField]
	private Button broccoli_bm;
	[SerializeField]
	private Button carrot_bm;
	[SerializeField]
	private Button tomato_bm;
	[SerializeField]
	private Button lettuce_bm;
	[SerializeField]
	private Button mushroom_bm;
	[SerializeField]
	private Button bacon_bm;
	[SerializeField]
	private Button meat_bm;
	[SerializeField]
	private Button parsley_bm;
	[SerializeField]
	private Button crouton_bm;
	[SerializeField]
	private Button cheese_bm;
	[SerializeField]
	private Button dressing_bm;
	[SerializeField]
	private Button sauce_bm;

	[Space(5)]
	[SerializeField]
	private GameObject canvas;

	private GameObject knob;
	private Transform canvasTran;

	private void Awake()
	{
		parsley_bm.onClick.AddListener(() => { on_Canvas(parsley); });
		cheese_bm.onClick.AddListener(() => { on_Canvas(cheese); });
		dressing_bm.onClick.AddListener(() => { on_Canvas(dressing); });
		sauce_bm.onClick.AddListener(() => { on_Canvas(sauce); });
	}

	private void on_Canvas(GameObject equipment)
	{
		if (knob == null)
		{
			knob = Instantiate(equipment, canvasTran, false);
			knob.transform.SetParent(canvas.transform, false);
		}
		else
		{
			Destroy(knob);
		}
	}

}
