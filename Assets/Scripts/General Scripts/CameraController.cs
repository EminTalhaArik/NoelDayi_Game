using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerObject")
        {
            //Oyun bitir.
            Destroy(collision.gameObject);
        }
    }
}
