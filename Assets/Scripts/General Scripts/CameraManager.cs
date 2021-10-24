using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public float speed;
    GameObject player;

    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    
    void Update()
    {
        this.transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, minX,maxX) * speed,Mathf.Clamp(player.transform.position.y,minY,maxY)* speed,this.transform.position.z);
    }
}
