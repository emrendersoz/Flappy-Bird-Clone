using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Button startBtn;
    public Kus dead;
    public Text highScore;
    public int hScore;
    void Start()
    {
        Time.timeScale = 0;
        score = 0;
        hScore = PlayerPrefs.GetInt("Hscore");
        highScore.text = hScore.ToString();
        scoreText.text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            if (!dead.isDead)
            {
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Time.timeScale = 1;
                    }
                }
            }
        }
    }
    public void updateScore()
    {
        score++;
        if (score > hScore)
        {
            hScore = score;
            highScore.text = hScore.ToString();
        }
        scoreText.text = score.ToString();
    }
    public void OnDestroy()
    {
        PlayerPrefs.SetInt("Hscore", hScore);
    }
    public void RestartGame()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(0);
    }


}
