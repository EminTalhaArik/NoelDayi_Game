using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{

    public GameObject[] objectPrefabs;
    public int count;

    float lastPos;
    public float upperPos;

    void Start()
    {
        for(int i = 0; i<count; i++)
        {
            GameObject spawnObject = Instantiate(objectPrefabs[Random.Range(0, objectPrefabs.Length)]);

            if(i == 0)
            {
                spawnObject.transform.position = new Vector3(0, 3.85f, 0);
            }
            else
            {
                spawnObject.transform.position = new Vector3(lastPos + upperPos, 3.85f, 0);
            }

            lastPos = spawnObject.transform.position.x;

        }
    }

    public void spawn()
    {
        GameObject spawnObject = Instantiate(objectPrefabs[Random.Range(0, objectPrefabs.Length)]);

        spawnObject.transform.position = new Vector3(lastPos + upperPos, 3.85f, 0);

        lastPos = spawnObject.transform.position.x;
    }
}

