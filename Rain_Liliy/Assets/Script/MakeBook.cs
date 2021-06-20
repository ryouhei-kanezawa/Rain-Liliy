using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class MakeBook : MonoBehaviour
{
    /*
    [SerializeField]
    private int objLength = 7;
    */

    [SerializeField]
    private GameObject[] Peas;

    private int even = 0;
    private int odd = 0;
    private GameObject[][] books = new GameObject[7][];
    void Start()
    {
		for (int i = 0; i < books.Length; i++)
		{
			if (i % 2 == 0)
			{
                books[i] = new GameObject[6];
			}
			else
			{
                books[i] = new GameObject[5];
			}
		}

        SpawnPeas();
    }

    private void Update()
    {
        NewPeas();
    }

    void SpawnPeas()
    {
        for (int i = 0; i < 7; i++)
        {
			if (i % 2 == 0)
			{
				for (int j = 0; j < 6; j++)
				{
                    //Debug.Log("偶数");
                    int r = Random.Range(0, 5);
                    books[i][j] =
                        Instantiate(Peas[r], new Vector3(-34f + (even * 22), 22f - (j * 14), 140f), Quaternion.identity);
                }
                even++;
			}
			else
			{
				for (int j = 0; j < 5; j++)
                {
                    //Debug.Log("奇数");
                    int r = Random.Range(0, 5);
                    books[i][j] =
                        Instantiate(Peas[r], new Vector3(-23f + (odd * 22), 15f - (j * 14), 140f), Quaternion.identity);
                }
                odd++;
			}
        }
    }

    private async void NewPeas()
	{
        for (int i = 0; i < books.Length; i++)
        {
            for (int j = 0; j < books[i].Length; j++)
            {
                if (books[i][j] == null)
                {
                    Debug.Log(i + " " + j);
                    int r = Random.Range(0, 5);
                    books[i][j] =
                        Instantiate(Peas[r], new Vector3(-34f + (i * 11), 34f, 140f), Quaternion.identity);
                }
            }
        }
	}

    void ReSpawnPeas()
    {

    }
}

/* array
        // Y方向高さ
        Hex_Height = Hex_Width * Mathf.Sin(60.0f * Mathf.Deg2Rad);
        
    	// X方向のずれ
        Hex_Adjust = Hex_Width * Mathf.Cos(60.0f * Mathf.Deg2Rad);
        
        float grid_X = Hex_Width * hexPos.x + Hex_Adjust * Mathf.Abs(hexPos.y % 2);
        float grid_Y = Hex_Height * hexPos.y;

        return new Vector3(grid_X, grid_Y, 0.0f);

        ----------------

        y = j * 20
        x = i * ( i % 2 * 20 * 0.5 )
 */
