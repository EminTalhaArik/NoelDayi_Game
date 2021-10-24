using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftScoreDowner : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GiftBox")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().scoreDowner();
        }
        else if (collision.gameObject.tag == "PlayerObject")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().endGame();
        }
    }

}
