using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using TMPro;

public class mushroomText : MonoBehaviour
{

    public TextMeshProUGUI mushMesh;


    // Update is called once per frame
    void Update()
    {
        //Ghost Cabbage
        if (countCollected.mushroomCount == 0)
        {
            mushMesh.enabled = false;
        }
        else
        {
            mushMesh.text = countCollected.mushroomCount.ToString();
            mushMesh.enabled = true;

        }
    }

}
