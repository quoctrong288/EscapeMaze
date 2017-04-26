using UnityEngine;
using System.Collections;

public class LoadMap : MonoBehaviour
{

    public GameObject wall;

    const int ROWS = 16;
    const int COLUMNS = 11;

    int[,] map = {
    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
    {1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1},
    {1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1},
    {1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1},
    {1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1},
    {1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1},
    {1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1},
    {1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1},
    {1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1},
    {1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1},
    {1, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1},
    {1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1},
    {1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1},
    {1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1},
    {1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
    {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} };

    Vector3 StartPos = new Vector3(-2.5565f, 4.744f, 0);

    void Start()
    {
        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLUMNS; j++)
            {
                if (map[i, j] == 1)
                {
                    GameObject a = Instantiate(wall);
                    a.transform.position = StartPos;
                    StartPos += new Vector3(0.512f, 0, 0);
                    a.transform.parent = this.transform;
                }
                else
                {
                    StartPos += new Vector3(0.512f, 0, 0);
                }
            }
            StartPos -= new Vector3(0, 0.512f, 0);
            StartPos.x = -2.5565f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
