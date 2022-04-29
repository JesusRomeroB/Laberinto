using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int width = 7;
    public int height = 7;

    private int m = 15;

    public Tile TilePrefab;
    public Wall WallPrefab;

    public Player PlayerFab;
    public Enemy EnemyFab;
    // Start is called before the first frame update
    void Start()
    {
        GenerateBoard();
    }
    void GenerateBoard()
    {
        int obstacleCount = 0;

        // var player = Instantiate(PlayerFab, new Vector2(0, 0), Quaternion.identity);
        // var enemy = Instantiate(EnemyFab, new Vector2(width - 1, height - 1), Quaternion.identity);

        // for (int i = 0; i < width; i++)
        // {
        //     for (int j = 0; j < height; j++)
        //     {
        //         if (obstacleCount < m && ((i != 0 && j != 0) || (i != (width - 1) && j != (height - 1))))
        //         {
        //             if (Random.Range(0, 10) <= 2)
        //             {
        //                 obstacleCount++;
        //                 var cell = Instantiate(WallPrefab, new Vector2(i, j), Quaternion.identity);
        //             }
        //             else
        //             {
        //                 var cell = Instantiate(TilePrefab, new Vector2(i, j), Quaternion.identity);
        //             }
        //         }
        //         else
        //         {
        //             var cell = Instantiate(TilePrefab, new Vector2(i, j), Quaternion.identity);
        //         }

        //     }
        // }

        // var center = new Vector2((float)width / 2 - 0.5f, (float)height / 2 - 0.5f);
        // Camera.main.transform.position = new Vector3(center.x, center.y, -10);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
