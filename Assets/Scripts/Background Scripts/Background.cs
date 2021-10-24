using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    GameObject mainCamera;
    GameObject backgroundSpawner;

    bool devam = true;

    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        backgroundSpawner = GameObject.Find("BackgroundManager");
    }

    
    void Update()
    {
        if (devam)
        {
            devam = false;
            StartCoroutine(replay());
        }
    }

    IEnumerator replay()
    {
        yield return new WaitForSeconds(5);

        if(this.transform.position.x + 25 < mainCamera.transform.position.x)
        {
            backgroundSpawner.GetComponent<BackgroundSpawner>().spawn();
            Destroy(this.gameObject);
        }

        devam = true;
    }
}
