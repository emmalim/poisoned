using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class countCollected : MonoBehaviour
{
    public static int cabbageCount = 0;
    public static int tomatoCount = 0;
    public static int mushroomCount = 0;
    public static int bottleCount = 0;
    public static int lemonCount = 0;
    public static int coinCount = 0;

    public static bool touched = false;

    private string itemTag;

    public AudioSource pickup;
    
    void OnTriggerEnter(Collider other)
    {
        //get item tag
        itemTag = other.gameObject.tag;
        Debug.Log("COLLIDED WITH: " + other.name + " W/ TAG: " + itemTag);

        //if it's a recipe item, obj disappears, added to inventory
        if (itemTag == "cabbage")
        {
            cabbageCount += 1;
            other.gameObject.SetActive(false);

            pickup.Play();

        }
        else if (itemTag == "tomato")
        {
            tomatoCount += 1;
            other.gameObject.SetActive(false);

            pickup.Play();

        }
        else if (itemTag == "mushroom")
        {
            mushroomCount += 1;
            other.gameObject.SetActive(false);

            pickup.Play();

        }
        else if (itemTag == "bottle")
        {
            bottleCount += 1;
            other.gameObject.SetActive(false);

            pickup.Play();

        }
        else if (itemTag == "lemon")
        {
            lemonCount += 1;
            other.gameObject.SetActive(false);

            pickup.Play();

        }
        else if (itemTag == "coin"){
            coinCount += 1;
            other.gameObject.SetActive(false);

            pickup.Play();
        }
        else if(itemTag == "antidote")
        {
            touched = true;
            Debug.Log("TOUCHED" + touched);
        }


    }

    void OnTriggerExit(Collider other)
    {
        itemTag = "Untagged";
    }


    void Update()
    {

    }
}
