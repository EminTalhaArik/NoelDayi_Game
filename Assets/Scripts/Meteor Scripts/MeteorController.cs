using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{

    int rakam = 0;

    public GameObject meteorObject;

    void control()
    {
        if(rakam == 1)
        {
            rakam = 0;
            GameObject.FindGameObjectWithTag("Player").GetComponent<HealthScript>().playMeteorSound();
            GameObject.FindGameObjectWithTag("Player").GetComponent<HealthScript>().healthDowner();
            meteorObject.gameObject.GetComponent<MeteorManager>().thisIsDestroyed = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerObject")     
        {
            rakam++;
            control();
        }
    }
}
