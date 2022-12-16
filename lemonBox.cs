using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lemonBox : MonoBehaviour
{
    //this script is on the lemon Box in the shop
    private int count = 0;
    public static bool givenLemons = false;
    public GameObject bottle1;
    public GameObject bottle2;
    public AudioSource clink;

    private void OnTriggerEnter(Collider other)
    {
        //if you've pulled out lemons from your inventory
        if (other.gameObject.tag == "lemon2")
        {
            count += 1;
            Debug.Log("paid " + count + " lemons to shop");
            other.gameObject.SetActive(false);
        }
        if (count >= 4)
        {
            givenLemons = true;
            bottle1.SetActive(true);
            bottle2.SetActive(true);
            clink.Play();

        }
    }

    private void Update()
    {
        
    }

}
