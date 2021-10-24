using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefab;

    public GameObject birdSpawnYMax;
    public GameObject birdSpawnYMin;

    int spawnTime;

    bool tekrar = true;

    GameObject mainCameraObject;

    
    void Start()
    {
        mainCameraObject = GameObject.FindGameObjectWithTag("MainCamera");   
    }

    void Update()
    {
        if (tekrar)
        {
            tekrar = false;
            StartCoroutine(spawnerObject());
        }
    }

    IEnumerator spawnerObject()
    {
        spawnTime = Random.Range(1, 6);
        yield return new WaitForSeconds(spawnTime);

        float birdYPos = Random.Range(birdSpawnYMax.transform.position.y, birdSpawnYMin.transform.position.y);
        

        Vector3 birdSpawnPoint = new Vector3(mainCameraObject.transform.position.x + 15,birdYPos,0);

        GameObject spawnObjext = Instantiate(birdPrefab,birdSpawnPoint,Quaternion.identity);

        tekrar = true;
    }
}
