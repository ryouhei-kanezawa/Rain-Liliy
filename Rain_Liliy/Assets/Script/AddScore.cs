using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    [SerializeField]
    private Slider scoreSlider;
    [SerializeField]
    private float add = 300f;
    [SerializeField]
    private float mag = 1.5f;

    private float score;
    private float maxScore;

    private void Update()
    {
        //Debug.Log(score);
    }

    public void ScoreAdd(int count)
    {
        int _fixed =  count - 3;
        var fixed_mag = 1f;

        for (int i = 0; i < _fixed; i++)
        {
            fixed_mag += mag;
        }

        scoreSlider.value += add * fixed_mag;
        score =(int)(score + add * fixed_mag);
    }
        
}
