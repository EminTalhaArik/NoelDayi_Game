using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [HideInInspector]
    public int score = 0;

    public Text scoreText;

    public GameObject gameOverPanel;
    public Text gameOverPanelScoreText;

    public Text highScoreText;

    public GameObject gamePausePanel;

    bool tekrar = true;

    public float timeDeneme;
    

    void Start()
    {
        timeDeneme = Time.deltaTime;
        scoreText.text = "" + score;
        Time.timeScale = 1;
        gamePausePanel.SetActive(false);
        timeDeneme = Time.timeScale;
        gameOverPanel.SetActive(false);
        highScoreController();
    }

    private void Update()
    {
        if (tekrar && Time.timeScale < 3.5f)
        {
            tekrar = false;
            StartCoroutine(timeUpper());
        }
    }

    IEnumerator timeUpper()
    {
        
        yield return new WaitForSeconds(Random.Range(4,10));
        Time.timeScale += Random.Range(0.01f, 0.1f);
        timeDeneme = Time.timeScale;
        tekrar = true;
    }

    public void endGame()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        gameOverPanelScoreText.text = "" + score;
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("highScore");
    }

    public void pauseGame()
    {
        GameObject.Find("SoundManager").GetComponent<AudioSource>().Play();
        Time.timeScale = 0;
        gamePausePanel.SetActive(true);
    }


    public void mainMenuButton()
    {
        GameObject.Find("SoundManager").GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void replayGame()
    {
        GameObject.Find("SoundManager").GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void continueButton()
    {
        GameObject.Find("SoundManager").GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
        gamePausePanel.SetActive(false);
    }

    public void scoreUpper()
    {
        score++;
        highScoreController();
        updateScoreText();
    }

    public void highScoreController()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }

    public void scoreDowner()
    {
        if(score -1 >= 0)
        {
            score--;
            updateScoreText();
        }
    }

    public void updateScoreText()
    {
        scoreText.text = "" + score;
    }

}
