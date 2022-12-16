using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class recipe : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject tableRecipe; //recipe on the desk
    public GameObject handRecipe; //recipe held in hand

    public SteamVR_Action_Boolean triggerRecipe; //button (X on left hand controller)
    

    // Update is called once per frame
    void Update()
    {

        if (triggerRecipe.GetStateDown(SteamVR_Input_Sources.LeftHand) && !tableRecipe.activeSelf) //if button is pressed and the table recipe has been picked up
        {
            if (handRecipe.activeSelf) //if the recipe in hand is active, set inactive
            {
                handRecipe.SetActive(false);
            }
            else //if the recipe in hand is inactive, make it active
            {
                handRecipe.SetActive(true);
            }
        }
        
    }
}
