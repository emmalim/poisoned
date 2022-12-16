using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marketStallCollider : MonoBehaviour
{
    public GameObject speechBubble;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player" )
        {
            speechBubble.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    
}
