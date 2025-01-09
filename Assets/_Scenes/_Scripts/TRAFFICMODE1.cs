using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRAFFICMODE1 : MonoBehaviour
   
{
    public PlayerScript mnger;
    public GameObject bariiers;
    // Start is called before the first frame update

   public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Car")
        {
            gameObject.GetComponent<Rigidbody>().drag = 2.0f;
            bariiers.gameObject.GetComponent<Animator>().SetBool("Animon", true);
        }
    }
    private void OnTriggerExit(Collider col)
    {
        bariiers.gameObject.GetComponent<Animator>().SetBool("Animoff", true);
    }
}
