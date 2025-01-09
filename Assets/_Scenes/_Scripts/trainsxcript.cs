using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainsxcript : MonoBehaviour
{
   public  GameObject trafficlightred,trafficlightgreen;
    public GameObject[] trafficlights,cube;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lights")
        {
            StartCoroutine(trafficlight());
            trafficlightred.SetActive(true);
            trafficlightgreen.SetActive(false);
            trafficlights[0].SetActive(true);
            trafficlights[1].SetActive(false);
            trafficlights[2].SetActive(true);
            trafficlights[3].SetActive(false);
            trafficlights[4].SetActive(true);
            trafficlights[5].SetActive(false);
            
            
        }
        if (other.gameObject.tag == "lights1")
        {
            StartCoroutine(trafficlight1());
            trafficlightred.SetActive(true);
            trafficlightgreen.SetActive(false);
            trafficlights[0].SetActive(true);
            trafficlights[1].SetActive(false);
            trafficlights[2].SetActive(true);
            trafficlights[3].SetActive(false);
            trafficlights[4].SetActive(true);
            trafficlights[5].SetActive(false);
            
            
        }

    }
    IEnumerator trafficlight()
    {
        yield return new WaitForSeconds(12f);
        trafficlightred.SetActive(false);
        trafficlightgreen.SetActive(true);
        trafficlights[0].SetActive(false);
        trafficlights[1].SetActive(true);
        trafficlights[2].SetActive(false);
        trafficlights[3].SetActive(true);
        trafficlights[4].SetActive(false);
        trafficlights[5].SetActive(true);
        
    }
    IEnumerator trafficlight1()
    {
        yield return new WaitForSeconds(12f);
        trafficlightred.SetActive(false);
        trafficlightgreen.SetActive(true);
        trafficlights[0].SetActive(false);
        trafficlights[1].SetActive(true);
        trafficlights[2].SetActive(false);
        trafficlights[3].SetActive(true);
        trafficlights[4].SetActive(false);
        trafficlights[5].SetActive(true);
       
    }


}
