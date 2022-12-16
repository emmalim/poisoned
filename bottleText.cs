using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using TMPro;

public class bottleText : MonoBehaviour
{

    public TextMeshProUGUI bottleMesh;


    // Update is called once per frame
    void Update()
    {
        //Ghost Cabbage
        if (countCollected.bottleCount == 0)
        {
            bottleMesh.enabled = false;
        }
        else
        {
            bottleMesh.text = countCollected.bottleCount.ToString();
            bottleMesh.enabled = true;

        }
    }

}
