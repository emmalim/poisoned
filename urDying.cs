using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urDying : MonoBehaviour
{
    //script is attached to vignettePostProcess object (child of Player)
    public GameObject blackScreen;
    public GameObject screen2;
    public GameObject leftHand;
    public GameObject rightHand;
    private bool poisoned = true;
    private bool die = false;

    IEnumerator co;
  


    void Start()
    {
        co = Death();
        StartCoroutine(co);
        
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(600); //wait 10minss before black screen reappears
        blackScreen.SetActive(true);
        screen2.SetActive(true);
        leftHand.SetActive(false);
        rightHand.SetActive(false);
    }

    void Update()
    {
        if (countCollected.touched)
        {
            Debug.Log("ENTERED");
            //co = Death();
            StopCoroutine(co);
            Debug.Log("stopped");
        }
    }
}
