using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpenAudio : MonoBehaviour
{
    public GameObject openedDoor;
    public GameObject emptyTimer;
    public AudioSource openingSound;

    // Update is called once per frame
    void Update()
    {
        if (openedDoor.activeSelf && emptyTimer.activeSelf)
        {
            openingSound.Play();
            emptyTimer.SetActive(false);
        }
    }
}
