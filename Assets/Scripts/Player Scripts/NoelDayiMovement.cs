using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoelDayiMovement : MonoBehaviour
{


    Joystick joystick;
    
    public float speed;
    public float xSpeed;

    GameObject player;

    void Start()
    {
        player = gameObject.transform.Find("noelDayi").gameObject;
        joystick = GameObject.FindGameObjectWithTag("Joystick").GetComponent<Joystick>();
    }

    
    void Update()
    {
        move();
    }

    void move()
    {
        float yAxisInput = joystick.Vertical;

        if (yAxisInput > 0)
        {
            player.transform.rotation = Quaternion.Euler(0, 0, 15);
        }
        else if (yAxisInput < 0)
        {
            player.transform.rotation = Quaternion.Euler(0, 0, -15);
        }
        else
        {
            player.transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        this.transform.rotation = Quaternion.Euler(0, 0, 0);
        this.transform.Translate(new Vector2(xSpeed * Time.deltaTime , yAxisInput * speed * Time.deltaTime));

    }

}
