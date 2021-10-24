using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    GameObject mainCamera;
    GameObject houseManager;

    int familyGiftCount;

    TextMesh happyCounterText; 

    bool replay = true;

    EdgeCollider2D myCollider;

    void Start()
    {
        myCollider = GetComponent<EdgeCollider2D>();
        happyCounterText = this.gameObject.transform.Find("FamilyGiftCount").GetComponent<TextMesh>();
        familyGiftCount = Random.Range(1,3);
        happyCounterText.text = "" + familyGiftCount;
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        houseManager = GameObject.Find("HouseManager");
    }

    
    void Update()
    {

        if (replay)
        {
            replay = false;
            StartCoroutine(cameraControl());
            
        }
        
    }

    public void giftControllerAndScoreUpper()
    {
        
        if(familyGiftCount -1 >= 0)
        {
            familyGiftCount--;
            HappyTextUpdate();
            giftController();
        }
    }

    public void giftController()
    {
        if(familyGiftCount == 0)
        {
            myCollider.enabled = false;
            gameObject.GetComponent<AudioSource>().Play();
            GameObject.Find("GameManager").GetComponent<GameManager>().scoreUpper();
            Debug.Log("Ev mutlu oldu.");
        }
    }

    public void HappyTextUpdate()
    {
        happyCounterText.text = "" + familyGiftCount;
    }

    IEnumerator cameraControl()
    {
        yield return new WaitForSeconds(5);
        if (this.transform.position.x + 15 < mainCamera.transform.position.x)
        {
            houseManager.GetComponent<HouseManager>().createHouse();
            Destroy(this.gameObject);
            
        }

        replay = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PlayerObject")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().endGame();
        }
    }
}
