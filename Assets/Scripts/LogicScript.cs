using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text textScore; //texto do canvas
    public int  playerScore; //variável de armazenamento dos pontos

    public Text highScore;

    public GameObject gameOverScreen;

    //Pause
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;

    public GameObject jumpBtn;
    public GameObject pauseBtn;


    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }*/
        
        
    }

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        textScore.text = playerScore.ToString();

        if(playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            highScore.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        jumpBtn.SetActive(false);
    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        jumpBtn.SetActive(true);
        pauseBtn.SetActive(true);
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        jumpBtn.SetActive(false);
        pauseBtn.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }


}
