using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitTime : MonoBehaviour
{
    [SerializeField]
    private GameObject sec;
    [SerializeField]
    private float limit = 30.0f;

    private float rotateValue = 0;
    private Transform _transform;
    private float turn;
    //private Vector3 pos;
    //private bool coroutineBool = true;

    private void Awake()
    {
        _transform = sec.GetComponent<Transform>();
        turn = (int)(-360 / limit);
    }

    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        rotateValue += turn * Time.deltaTime;

        Debug.Log(rotateValue + "�x�����");

        _transform.localEulerAngles = new Vector3(0f, 0f, rotateValue);
    }
}
