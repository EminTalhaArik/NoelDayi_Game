using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftBoxSPawnAndManager : MonoBehaviour
{

    public List<GameObject> GiftBoxes;
    public GameObject giftBoxSpawnPos;

    void Start()
    {
        
    }

    
    public void giftBoxSpawn()
    {
        int giftBoxNumber = Random.Range(0, GiftBoxes.Count);
        GameObject giftBox = Instantiate(GiftBoxes[giftBoxNumber]);
        giftBox.transform.position = giftBoxSpawnPos.transform.position;
        
    }

    void Update()
    {
        
    }
}
