using UnityEngine;

public class MakeBook : MonoBehaviour
{
    [SerializeField]
    private GameObject[] peas;

    void Start()
    {
        SpawnPeas();
    }

    void Update()
    {
        
    }

    void SpawnPeas()
    {
        for(int i = 0; i < 39; i++)
        {
            int r = Random.Range(0, 5);
            var ball = Instantiate(peas[r]);
            ball.transform.position = new Vector2(Random.Range(-2f, 2f), Random.Range(2f, 4f));
        }
    }
}
