using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Grid : ScriptableObject
{
    private int width;
    private int height;
    private int tileSize;
    private Tile tilePrefab;
    private Tile[,] gridArray;


    public Grid(int width, int height, int tileSize, Tile tilePrefab)
    {

        this.width = width;
        this.height = height;
        this.tileSize = tileSize;
        this.tilePrefab = tilePrefab;

        generateBoard();
    }

    private void generateBoard()
    {
        Tile tile;
        gridArray = new Tile[width, height];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                var p = new Vector2(i, j) * tileSize;
                tile = Instantiate(tilePrefab, p, Quaternion.identity);
                tile.Init(this, (int)p.x, (int)p.y, true);

                if (Random.Range(0, 10) <= 2)
                {
                    tile.SetWalkable(false);
                }
                else
                {

                }


                gridArray[i, j] = tile;
            }
        }

        var center = new Vector2((float)height / 2 - 0.5f, (float)width / 2 - 0.5f);

        Camera.main.transform.position = new Vector3(center.x, center.y, -5);
    }

    internal int GetHeight()
    {
        return height;
    }

    internal int GetWidth()
    {
        return width;
    }

    // public void CellMouseClick(Cell cell)
    // {
    //     //cell.SetText("Click on cell "+cell.x+ " "+ cell.y);
    //     BoardManager.Instance.CellMouseClick(cell.x, cell.y);
    // }



    public Tile GetGridObject(int x, int y)
    {
        return gridArray[x, y];
    }

    internal float GetTileSize()
    {
        return tileSize;
    }
}

