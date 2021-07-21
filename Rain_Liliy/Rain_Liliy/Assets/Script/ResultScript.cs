using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using System.Threading.Tasks;

public class ResultScript : MonoBehaviour
{
    [SerializeField]
    private Button retry;
    [SerializeField]
    private Button end;
    [SerializeField]
    private GameObject resultObject;
    [SerializeField]
    private Text text;
    [SerializeField]
    private AddScore _add;

    [Space(10)]

    [SerializeField]
    private GameObject finish;

    private bool stop_W;
    void Awake()
    {
        Time.timeScale = 1f;
        stop_W=false;
        resultObject.SetActive(false);
        retry.onClick.AddListener(Retry);
        end.onClick.AddListener(Quit);
    }

    async void ResultSW(bool sw)
    {
        if (sw)
        {
            finish.transform.DOMoveX(0,2.0f)
                .SetEase(Ease.OutQuad);
            await Task.Delay(3000);
            Time.timeScale = 0f;
        }
        resultObject.SetActive(sw);
    }

    public void GetTime(float value)
    {
        if (value <= -360f)
        {
            stop_W=true;
            ResultSW(true);
            text.text = "Score:" + _add.GetScore();
        }
        else
        {
            ResultSW(false);
        }
    }

    private void Retry()
    {
        SceneManager.LoadScene(1);
    }

    private void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public bool SendStop()
    {
        return stop_W;
    }
}
