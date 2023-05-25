using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class player : MonoBehaviour
{
    public GameObject upRight;
    public GameObject upLeft;
    public GameObject downRight;
    public GameObject downLeft;
    public GameObject loss1;
    public GameObject loss2;
    public GameObject loss3;
    public GameObject gameOver;
    public bool up;
    public bool down;
    public bool right;
    public bool left;
    public static float state = 0;
    public static int score = 0;
    public static int fails = 0;
    public UnityEngine.UI.Text scoreText;
    public UnityEngine.UI.Text best;
    public UnityEngine.UI.Text difficulty;
    public static float bestScore = 0;
    public static bool ded = false;


    // Start is called before the first frame update
    void Start()
    {
        fails = 0;
        gameOver.SetActive(false);
        upRight.SetActive(true);
        upLeft.SetActive(false);
        downRight.SetActive(false);
        downLeft.SetActive(false);

        loss1.SetActive(false);
        loss2.SetActive(false);
        loss3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Current_Points: " + score.ToString();

        if(fails == 1) {
            loss1.SetActive(true);
            loss2.SetActive(false);
            loss3.SetActive(false);
        }
        if(fails == 2) {
            loss1.SetActive(true);
            loss2.SetActive(true);
            loss3.SetActive(false);
        }
        if(fails == 3) {
            loss1.SetActive(true);
            loss2.SetActive(true);
            loss3.SetActive(true);
            gameOver.SetActive(true);
            ded = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            up = true;
            down = false;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            left = true;
            right = false;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            down = true;
            up = false;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            right = true;
            left = false;
        }

        if(up && right) {
            state = 0;
            upRight.SetActive(true);
            upLeft.SetActive(false);
            downRight.SetActive(false);
            downLeft.SetActive(false);
        }
        if(up && left) {
            state = 1;
            upLeft.SetActive(true);
            upRight.SetActive(false);
            downRight.SetActive(false);
            downLeft.SetActive(false);
        }
        if(down && left) {
            state = 2;
            downLeft.SetActive(true);
            upRight.SetActive(false);
            upLeft.SetActive(false);
            downRight.SetActive(false);
        }
        if(down && right) {
            state = 3; 
            downRight.SetActive(true);
            upRight.SetActive(false);
            upLeft.SetActive(false);
            downLeft.SetActive(false);
        }
    }

    public void restart() {
        gameOver.SetActive(false);
        if(bestScore < score) {
            bestScore = score;  
        }
        best.text = "Best: " + bestScore.ToString();
        spawner0.timer = 0;
        spawner0.timerAll = 0;
        spawner0.spawnRate = 10f;
        fails = 0;
        gameOver.SetActive(false);
        upRight.SetActive(true);
        upLeft.SetActive(false);
        downRight.SetActive(false);
        downLeft.SetActive(false);

        loss1.SetActive(false);
        loss2.SetActive(false);
        loss3.SetActive(false);
        difficulty.text = "Difficulty: 1 / 5";
        ded = false;
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
