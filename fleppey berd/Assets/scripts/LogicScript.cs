using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int Score = 0 ;
    public Text InterfaceScore;
    public GameObject gameOverScreen;
    public GameObject bird;
    public GameObject pipeSpawner;
    public GameObject ScoreText;
    public GameObject startGameParent;

    [ContextMenu("Add Score")]
    public void addScore()
    {
        Score++;
        InterfaceScore.text = Score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void startGame()
    {
        bird.SetActive(true);
        pipeSpawner.SetActive(true);
        ScoreText.SetActive(true);
        startGameParent.SetActive(false);

    }
}



