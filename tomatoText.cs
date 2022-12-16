using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using TMPro;

public class tomatoText : MonoBehaviour
{

    public TextMeshProUGUI tomatoMesh;


    // Update is called once per frame
    void Update()
    {
        //Ghost Cabbage
        if (countCollected.tomatoCount == 0)
        {
            tomatoMesh.enabled = false;
        }
        else
        {
            tomatoMesh.text = countCollected.tomatoCount.ToString();
            tomatoMesh.enabled = true;

        }
    }

}
