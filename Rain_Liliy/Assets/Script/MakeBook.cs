using UnityEngine;

public class MakeBook : MonoBehaviour
{
    /*
    [SerializeField]
    private float SpawnX;
    [SerializeField]
    private float SpawnY;
    */

    [SerializeField]
    private GameObject[] Peas;

    void Start()
    {
        SpawnPeas();
    }

    void SpawnPeas()
    {
        for(int i = 0; i < 39; i++)
        {
            int r = Random.Range(0, 5);
            var ball = Instantiate(Peas[r]);
            ball.transform.position = new Vector2(Random.Range(-2f, 2f), Random.Range(2f, 4f));
        }
    }

    public void NewPeas(int books)
	{
        Debug.Log("’Ç‰Á");
		for (int i = 0; i < books; i++)
		{
            int r = Random.Range(0, 5);
            var ball = Instantiate(Peas[r]);
            ball.transform.position = new Vector2(Random.Range(-32f, 32f), 40f);
        }
	}

    void ReSpawnPeas()
    {

    }
}
