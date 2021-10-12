using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class seasoning_manu : MonoBehaviour
{
	[Header("’²–¡—¿")]
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
	[SerializeField]
	private GameObject oil;
	[SerializeField]
	private GameObject pepper;
	[SerializeField]
	private GameObject suger;
	[SerializeField]
	private GameObject very_sauce;
	[SerializeField]
	private GameObject rosemary;
	[SerializeField]
	private GameObject mint;
	[SerializeField]
	private GameObject lemon;

	[Space(5)]

	[Header("’²–¡—¿‚Ìƒ{ƒ^ƒ“")]
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
	[SerializeField]
	private Button oil_bm;
	[SerializeField]
	private Button pepper_bm;
	[SerializeField]
	private Button suger_bm;
	[SerializeField]
	private Button veryS_bm;
	[SerializeField]
	private Button rosemary_bm;
	[SerializeField]
	private Button mint_bm;
	[SerializeField]
	private Button lemon_bm;


	[Space(5)]
	[SerializeField]
	private GameObject canvas;

	private GameObject knob;
	private Transform canvasTran;

	private void Awake()
	{
		/*
		parsley_bm.onClick.AddListener(() => on_Canvas(parsley));
		cheese_bm.onClick.AddListener(() => on_Canvas(cheese));
		dressing_bm.onClick.AddListener(() => on_Canvas(dressing));
		sauce_bm.onClick.AddListener(() => on_Canvas(sauce));
		oil_bm.onClick.AddListener(() => on_Canvas(oil));
		pepper_bm.onClick.AddListener(() => on_Canvas(pepper));
		suger_bm.onClick.AddListener(() => on_Canvas(suger));
		veryS_bm.onClick.AddListener(() => on_Canvas(very_sauce));
		*/
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
