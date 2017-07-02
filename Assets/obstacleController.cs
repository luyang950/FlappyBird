using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacleController : MonoBehaviour {
    public Vector2 moveSpeed = new Vector2(-4, 0);
    public float range = 4;

    private GameObject player;
    private GameObject score;
    private Text scoreText;

    private bool passed = false;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().velocity = moveSpeed;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);

        player = GameObject.Find("player(Clone)");
        score = GameObject.Find("ScoreText");
        scoreText = score.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        
        // Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x < -1000)
        {
            Destroy(gameObject);
        }

        if (transform.position.x <= player.transform.position.x && !passed)
        {
            int scoreNumber = int.Parse(scoreText.text);
            scoreNumber++;
            passed = true;
            scoreText.text = scoreNumber.ToString();
        }

        if (transform.position.x < player.transform.position.x - 200)
        {
            Destroy(gameObject);
        }
    }
}
