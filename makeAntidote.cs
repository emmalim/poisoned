using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeAntidote : MonoBehaviour
{
    private int cabbageIn = 0;
    private int tomatoIn = 0;
    private int mushIn = 0;
    private int bottleIn = 0;

    private string itemTag;

    public GameObject antidote;


    void OnTriggerEnter(Collider other)
    {
        //get item tag
        itemTag = other.gameObject.tag;
        Debug.Log("CAULDRON COLLIDED WITH: " + other.name + " W/ TAG: " + itemTag);

        //if it's a recipe item, obj disappears, added to inventory
        if (itemTag == "cabbage2")
        {
            other.gameObject.SetActive(false);
            Debug.Log(other.name + " hidden");
            cabbageIn += 1;
            Debug.Log("cabbageIn = " + cabbageIn);
        }
        else if (itemTag == "tomato2")
        {
            other.gameObject.SetActive(false);
            tomatoIn += 1;
            Debug.Log("tomatoIn = " + tomatoIn);
        }
        else if (itemTag == "mushroom2")
        {
            other.gameObject.SetActive(false);
            mushIn += 1;
            Debug.Log("mushIn = " + mushIn);
        }
        else if (itemTag == "bottle2")
        {
            other.gameObject.SetActive(false);
            bottleIn += 1;
            Debug.Log("bottleIn = " + bottleIn);
        }
    }


    // Update is called once per frame
    void Update()
    {
        //check all ingredients have been put into the cauldron
        if (cabbageIn >= 5 && tomatoIn >= 7 && mushIn >= 3 && bottleIn == 2)
        {
            antidote.SetActive(true);
        }
    }
}
