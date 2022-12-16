using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class showInventory : MonoBehaviour
{
    //this script goes on the object attachment point of right hand
    public GameObject inventory;
    public GameObject ghostCabbage;
    public GameObject ghostTomato;
    public GameObject ghostMushroom;
    public GameObject ghostBottle;
    public GameObject ghostLemon;
    public GameObject ghostCoin;
    public GameObject emptyMsg;


    private bool isOn;

    //check the status of button
    public SteamVR_Action_Boolean click;



    private void Update()
    {
        //Debug.Log("in update function of showInventory");

        //if button pressed and inventory not open, open inventory
        if (click.GetStateDown(SteamVR_Input_Sources.RightHand) && !inventory.activeSelf)
        {
            //Debug.Log("inventory opened!");
            inventory.SetActive(true);

            isOn = true;

            emptyMsg.SetActive(false);

            if (countCollected.cabbageCount == 0 && countCollected.tomatoCount == 0 && countCollected.mushroomCount == 0 && countCollected.bottleCount == 0 && countCollected.lemonCount == 0 && countCollected.coinCount == 0)
            {
                emptyMsg.SetActive(true);
            }

        }
        //if button is pressed and the inventory is active, set it to false
        else if (click.GetStateDown(SteamVR_Input_Sources.RightHand) && inventory.activeSelf)
        {
            //Debug.Log("inventory closed!");
            inventory.SetActive(false);

            isOn = false;
        }



        //set display (ghostItem appears if the itemCount > 0)
        if (isOn)
        {
            if (countCollected.cabbageCount <= 0) //if no cabbages...
            {
                ghostCabbage.SetActive(false);
            }
            else //if cabbages...
            {
                ghostCabbage.SetActive(true);

            }

            if (countCollected.tomatoCount <= 0) //if no tomatoes...
            {
                ghostTomato.SetActive(false);
            }
            else //if tomatoes...
            {
                ghostTomato.SetActive(true);
            }

            if (countCollected.mushroomCount <= 0) //if no shrooms...
            {
                ghostMushroom.SetActive(false);
            }
            else //if shrooms...
            {
                ghostMushroom.SetActive(true);

            }

            if (countCollected.bottleCount <= 0) //if no bottles...
            {
                ghostBottle.SetActive(false);
            }
            else //if bottles...
            {
                ghostBottle.SetActive(true);

            }

            if (countCollected.lemonCount <= 0) //if no lemons
            {
                ghostLemon.SetActive(false);
            }
            else //if yes lemons
            {
                ghostLemon.SetActive(true);
            }

            if (countCollected.coinCount <= 0)
            {
                ghostCoin.SetActive(false);
            }
            else
            {
                ghostCoin.SetActive(true);
            }
        }


    }

}
