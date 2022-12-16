using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopCollider : MonoBehaviour
{

    //this script is on the shop inside collider
    public GameObject speechBubble;


    private void OnTriggerEnter(Collider other)
    {
        //if you run into the box collider and you do not hAVE 4 lemons in your inventory
        if (other.gameObject.tag == "Player")
        {
            speechBubble.SetActive(true);
        }

    }




}
