using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int width = 5;
    public int height = 5;

    public Tile TilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        GenerateBoard();
    }
    void GenerateBoard()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                var cell = Instantiate(TilePrefab, new Vector2(i, j), Quaternion.identity);
            }

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
