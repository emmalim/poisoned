using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using TMPro;

public class coinText : MonoBehaviour
{

    public TextMeshProUGUI coinMesh;


    // Update is called once per frame
    void Update()
    {
        //Ghost Cabbage
        if (countCollected.coinCount == 0)
        {
            coinMesh.enabled = false;
        }
        else
        {
            coinMesh.text = countCollected.coinCount.ToString();
            coinMesh.enabled = true;

        }
    }

}