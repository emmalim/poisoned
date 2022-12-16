using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeOut : MonoBehaviour
{
    //this script should be on the object attachment point of right hand
    public GameObject cabInst;
    public GameObject tomInst;
    public GameObject mushInst;
    public GameObject botInst;
    public GameObject lemInst;
    public GameObject coinInst;

    public GameObject instPoint; //point for instantiation
    public GameObject instRotation;


    private string itemTag;
    void OnTriggerEnter(Collider other)
    {
        //get item tag
        itemTag = other.gameObject.tag;
        Debug.Log("COLLIDED WITH: " + other.name + " W/ TAG: " + itemTag);
    }
    
    void OnTriggerExit(Collider other)
    {
        //instantiate obj
        if (itemTag == "ghostCabbage")
        {
            GameObject InstantiatedCabbage = Instantiate(cabInst, instPoint.transform.position, instRotation.transform.rotation);
            countCollected.cabbageCount -= 1;
            Debug.Log("new cabbage");

        }
        else if (itemTag == "ghostTomato")
        {
            GameObject InstantiatedTomato = Instantiate(tomInst, instPoint.transform.position, instRotation.transform.rotation);
            countCollected.tomatoCount -= 1;
            Debug.Log("new tomato");

        }
        else if (itemTag == "ghostMushroom")
        {
            GameObject InstantiatedMushroom = Instantiate(mushInst, instPoint.transform.position, instRotation.transform.rotation);
            countCollected.mushroomCount -= 1;
            Debug.Log("new mushroom");

        }
        else if (itemTag == "ghostBottle")
        {
            GameObject InstantiatedBottle = Instantiate(botInst, instPoint.transform.position, instRotation.transform.rotation);
            countCollected.bottleCount -= 1;
            Debug.Log("new bottle");

        }
        else if (itemTag == "ghostLemon")
        {
            GameObject InstantiatedLemon = Instantiate(lemInst, instPoint.transform.position, instRotation.transform.rotation);
            countCollected.lemonCount -= 1;
            Debug.Log("new lemon");
        }
        else if (itemTag == "ghostCoin")
        {
            GameObject InstantiatedCoin = Instantiate(coinInst, instPoint.transform.position, instRotation.transform.rotation);
            countCollected.coinCount -= 1;
            Debug.Log("new coin");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
