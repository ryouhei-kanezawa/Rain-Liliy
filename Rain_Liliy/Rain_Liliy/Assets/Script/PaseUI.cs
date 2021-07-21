using UnityEngine;
using UnityEngine.UI;

public class PaseUI : MonoBehaviour
{
    [SerializeField]
    private Button Pause;
    [SerializeField]
    private GameObject pauseObject;

    private bool sw = true;

    void Awake()
    {
        pauseObject.SetActive(false);
        Pause.onClick.AddListener(PauseSW);
    }

    void PauseSW()
    {
        if (sw)
        {
            sw = false;
            pauseObject.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            sw = true;
            pauseObject.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
