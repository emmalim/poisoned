using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class shop : MonoBehaviour
{

    public UnityEvent triggerAction;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            triggerAction.Invoke();

        }
    }
}
