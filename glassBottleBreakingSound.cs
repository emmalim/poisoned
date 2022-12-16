using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassBottleBreakingSound : MonoBehaviour
{

    public AudioSource glass;
    public AudioSource music;
    public GameObject blackScreen; //in front of camera
    public GameObject screen2; //on the floor

    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(Opening());
    }

    IEnumerator Opening()
    {
       
        blackScreen.SetActive(true);
        screen2.SetActive(true);

        glass.PlayDelayed(3);
        

        yield return new WaitForSeconds(6); //wait 6 seconds before black screen disappears
        blackScreen.SetActive(false);
        screen2.SetActive(false);
        music.Play();
    }
}
