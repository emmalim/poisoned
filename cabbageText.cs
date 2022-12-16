using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using TMPro;

public class cabbageText : MonoBehaviour
{

    public TextMeshProUGUI cabbageMesh;


    // Update is called once per frame
    void Update()
    {
        //Ghost Cabbage
        if (countCollected.cabbageCount == 0)
        {
            cabbageMesh.enabled = false;
        }
        else
        {
            cabbageMesh.text = countCollected.cabbageCount.ToString();
            cabbageMesh.enabled = true;

        }
    }

}
