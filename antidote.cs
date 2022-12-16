using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antidote : MonoBehaviour
{
    public static bool poisoned = true; //player is poisoned
    public static bool touched = false; //player has touched the antidote

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            touched = true;
            Debug.Log("touched");
            poisoned = false;
        }
    }

}
