using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField]
    int spawnTime;
    public float spawnPosX;
    public float spawnPosY;

    bool tekrar = true;

    public GameObject meteorPrefabs;

    GameObject mainCameraObject;

    void Start()
    {
        
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
        spawnTime = Random.Range(3, 10);
        yield return new WaitForSeconds(spawnTime);

        mainCameraObject = GameObject.FindGameObjectWithTag("MainCamera");
        Vector3 objectSpawnPos = new Vector3(mainCameraObject.transform.position.x + spawnPosX, mainCameraObject.transform.position.y + spawnPosY,0);

        GameObject spawnObject = Instantiate(meteorPrefabs.gameObject, objectSpawnPos, Quaternion.identity);

        tekrar = true;
    }
}
