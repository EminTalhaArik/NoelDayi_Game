using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorManager : MonoBehaviour
{

    public GameObject meteor;
    public GameObject meteorTarget;
    public float speed = 5.0f;

    public bool thisIsDestroyed = false;

    void Start()
    {
        
    }

    void Update()
    { 
        if (!thisIsDestroyed)
        {
            meteor.gameObject.transform.position = Vector2.MoveTowards(meteor.transform.position, meteorTarget.transform.position, speed * Time.deltaTime);

        }
        else if (thisIsDestroyed)
        {
            Destroy(this.gameObject);
        }
    }
    

}
