using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using TMPro;

public class lemonText : MonoBehaviour
{

    public TextMeshProUGUI lemonMesh;


    // Update is called once per frame
    void Update()
    {
        //Ghost Cabbage
        if (countCollected.lemonCount == 0)
        {
            lemonMesh.enabled = false;
        }
        else
        {
            lemonMesh.text = countCollected.lemonCount.ToString();
            lemonMesh.enabled = true;

        }
    }

}