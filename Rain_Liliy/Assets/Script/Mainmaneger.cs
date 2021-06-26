using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmaneger : MonoBehaviour
{
    [SerializeField]
    private Button pazle;

    void Start()
    {
        pazle.onClick.AddListener(() => MoveScene(1));
    }

    void MoveScene(int num)
    {
        SceneManager.LoadScene(num);
    }
}
