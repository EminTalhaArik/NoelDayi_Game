using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GİftManager : MonoBehaviour
{
    GameObject house;
    void Start()
    {
        house = this.gameObject;
    }

    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "GiftBox")
        {
            //Skoru Arttır
            if(!(GameObject.Find("NoelDayiPlayer").transform.position.y > this.transform.position.y + 8))
            {
                house.GetComponent<House>().giftControllerAndScoreUpper();
            }
            Destroy(collision.gameObject);
        }
    }
    
}
