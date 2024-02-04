using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject square;
    public GameObject triangle;
    public GameObject circle;
    public GameObject hexagon;
    public GameObject diamond;
    public GameObject polygon;

    public Transform player;
    public Text hiScoreText;
    public Text scoreText;


    public float highScore;
    public float vert;
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("highScore");
        vert = player.position.y + 10;
        player = GameObject.Find("Player").transform;
        SpawnBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Mathf.Round(player.position.y).ToString();
        if(player.position.y > highScore)
        {
            highScore = Mathf.Round(player.position.y);
            PlayerPrefs.SetFloat("highScore", highScore);
        }
        vert = player.position.y + 10;
        hiScoreText.text = highScore.ToString();
    }

    void SpawnBlocks()
    {
        int rand = Random.Range(1, 6);
        float location = Random.Range(-6f, 6f);
        
        if (rand == 1)
        {
            Instantiate(square, new Vector2(location, vert), Quaternion.identity);
        }
        if (rand == 2)
        {
            Instantiate(triangle, new Vector2(location, vert), new Quaternion(180, Quaternion.identity.y, Quaternion.identity.z, Quaternion.identity.z));
        }
        if (rand == 3)
        {
            Instantiate(circle, new Vector2(location, vert), Quaternion.identity);
        }
        if (rand == 4)
        {
            Instantiate(hexagon, new Vector2(location, vert), Quaternion.identity);
        }
        if (rand == 5)
        {
            Instantiate(diamond, new Vector2(location, vert), Quaternion.identity);
        }
        if (rand == 6)
        {
            Instantiate(polygon, new Vector2(location, vert), Quaternion.identity);
        }

        Invoke("SpawnBlocks", 1.5f);
    }


}
