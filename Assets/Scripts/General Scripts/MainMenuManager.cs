using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public Text highScoreText;

    void Start()
    {
        highScoreText.text = "High Score : " + PlayerPrefs.GetInt("highScore");
    }

    void Update()
    {
        
    }

    public void playGame()
    {
        GameObject.Find("SoundManager").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        GameObject.Find("SoundManager").GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}
