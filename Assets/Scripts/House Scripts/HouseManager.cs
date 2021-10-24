using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour
{
    public GameObject[] houses;
    public float lastPos;
    public int count;

    public float minXPos;
    public float maxXPos;

    public float minYPos;
    public float maxYPos;

    void Start()
    {
        
        for(int i = 0; i < count; i++)
        {
            GameObject spawnObject = Instantiate(houses[Random.Range(0, houses.Length)]);

            spawnObject.transform.position = new Vector3(lastPos + Random.Range(minXPos, maxXPos), Random.Range(minYPos, maxYPos),0);

            lastPos = spawnObject.transform.position.x;
        }

    }

    public void createHouse()
    {
        GameObject spawnObject = Instantiate(houses[Random.Range(0, houses.Length)]);

        spawnObject.transform.position = new Vector3(lastPos + Random.Range(minXPos, maxXPos), Random.Range(minYPos, maxYPos), 0);

        lastPos = spawnObject.transform.position.x;
    }
    
}
