using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pay : MonoBehaviour
{
    //this script is on the coin box
    public GameObject boxColl;
    public GameObject speechBubble;
    private bool paid = false;
    public AudioSource clink;
    //on player, checking that they've collided with a market vendor

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin2")
        {
            Debug.Log("in the if statement!");
            paid = true;
            speechBubble.SetActive(false);
            boxColl.SetActive(false);
            clink.Play();
            Debug.Log("box collider gone!");
        }
    }
}
