using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{

    public float speed;

    int rakam = 0;

    AudioSource birdSound;

    void Start()
    {
        birdSound = GetComponent<AudioSource>();
        Destroy(this.gameObject, 15);
    }

    void Update()
    {
        this.transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void control()
    {
        if(rakam == 1)
        {
            rakam = 0;
            GameObject.FindGameObjectWithTag("Player").GetComponent<HealthScript>().playBirdSound();
            GameObject.FindGameObjectWithTag("Player").GetComponent<HealthScript>().healthDowner();
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerObject")
        {
            birdSound.Play();
            rakam++;
            control();
        }
    }
}
