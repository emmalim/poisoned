using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopDoorOpen : MonoBehaviour
{
    //this script should be on the shop door collider
    public GameObject closedDoor;
    public Animator openAnim;
    public GameObject openDoor;
    public AudioSource creak;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //open door anim

            openAnim.enabled = true; //play door audio
            this.gameObject.SetActive(false); //disable box collider
            openDoor.SetActive(true);
            creak.Play();
            closedDoor.SetActive(false);
        }
    }
}
