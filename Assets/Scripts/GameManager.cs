using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int width = 7;
    public int height = 7;

    //private int m = 15;

    public Tile TilePrefab;

    private Grid grid;

    private Player player;

    private Enemy enemy;
    public Wall WallPrefab;

    public Player PlayerFab;
    public Enemy EnemyFab;
    [SerializeField] private TextMeshProUGUI _text;
    private int score = 0;
    private int winningScore = 4;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = "Score: " + score;
        player = Instantiate(PlayerFab, new Vector2(-5.5f, -5.5f), Quaternion.identity);

        enemy = Instantiate(EnemyFab, new Vector2(2, 2), Quaternion.identity);
        enemy.Init(player);
    }
    private void Awake()
    {
        Instance = this;
    }

    public void Score()
    {
        score++;
        _text.text = "Score: " + score;
        player.transform.position = new Vector2(-5.5f, -5.5f);
        player.movePoint.position = new Vector2(-5.5f, -5.5f);
        Debug.Log("score " + score);
        var enemy = Instantiate(EnemyFab, new Vector2(Random.Range(1, 4), Random.Range(1, 4)), Quaternion.identity);
        enemy.Init(player);
    }

    // Update is called once per frame
    void Update()
    {
        // List<Tile> path = PathManager.Instance.FindPath(grid, (int)enemy.GetPosition.x, (int)enemy.GetPosition.y, (int)player.GetPosition.x, (int)player.GetPosition.y);

        //enemy.SetPath(path);
        if (score == winningScore)
        {
            PlayerPrefs.SetString("EndText", "YOU WON");
            SceneManager.LoadScene("EndScene");
        }
    }
}
