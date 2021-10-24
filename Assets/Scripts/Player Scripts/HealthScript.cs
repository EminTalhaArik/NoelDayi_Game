using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    int maxHealth = 5;
    public int nowHeatlh;

    public List<Image> kalpler = new List<Image>();

    public Sprite kirikKalp;
    public Sprite kalp;

    [HideInInspector]
    public int count;


    public GameObject birdSound;
    public GameObject meteorSound;

    void Start()
    {
        nowHeatlh = maxHealth;
    }

    void Update()
    {
    }

    public void healthDowner()
    {
        count++;
        heartController();
    }

    void heartController()
    {
        if (count == 1)
        {
            if (nowHeatlh - 1 >= 0)
            {
                nowHeatlh--;
                if(nowHeatlh <= 0)
                {
                    GameObject.Find("GameManager").GetComponent<GameManager>().endGame();
                }
                heartUpdater();
            }
        }
    }

    public void playBirdSound()
    {
        birdSound.GetComponent<AudioSource>().Play();
    }

    public void playMeteorSound()
    {
        meteorSound.GetComponent<AudioSource>().Play();
    }

    public void heartUpdater()
    {
        for(int i = 0; i < nowHeatlh; i++)
        {
            kalpler[i].sprite = kalp;
        }
        for(int i = nowHeatlh; i< maxHealth; i++)
        {
            kalpler[i].sprite = kirikKalp;
        }
        count = 0;
    }
}
