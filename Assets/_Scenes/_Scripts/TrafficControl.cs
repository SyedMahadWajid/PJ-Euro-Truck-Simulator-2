using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWS;
using UnityEngine.SceneManagement;

public class TrafficControl : MonoBehaviour
{
   // public GameObject Traffic;
    public AudioClip Collect;
    public GameObject[] Wheels;
    
    // Use this for initialization

    void Start()
    {

    }

   // Update is called once per frame
    void Update()
    {
     
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) /*|| other.gameObject.CompareTag("player"))*/
        {
            Debug.Log("ok");
            this.transform.GetComponent<splineMove>().Pause();
            GetComponent<AudioSource>().PlayOneShot(Collect);
            Wheels[0].GetComponent<Rotate>().enabled = false;
            Wheels[1].GetComponent<Rotate>().enabled = false;
            Wheels[2].GetComponent<Rotate>().enabled = false;
            Wheels[3].GetComponent<Rotate>().enabled = false;
           // gameplay.instance.Traffic();
            //foreach (GameObject w in Wheels)
            //{
            //    w.GetComponent<Rotate>().enabled = false;
            //}
           

        }
        if (other.gameObject.CompareTag("Player"))
        {

            this.transform.GetComponent<splineMove>().Resume();
            GetComponent<AudioSource>().PlayOneShot(Collect);
            //foreach (GameObject w in Wheels)
            //{
            //    w.GetComponent<Rotate>().enabled = true;
            //}
            Wheels[0].GetComponent<Rotate>().enabled = false;
            Wheels[1].GetComponent<Rotate>().enabled = false;
            Wheels[2].GetComponent<Rotate>().enabled = false;
            Wheels[3].GetComponent<Rotate>().enabled = false;

        }

    }
    IEnumerator OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player") )/*|| other.gameObject.CompareTag("player"))*/
        {
            yield return new WaitForSeconds(6.5f);
            this.transform.GetComponent<splineMove>().Resume();
            //foreach (GameObject w in Wheels)
            //{
            //    w.GetComponent<Rotate>().enabled = true;
            //}
            Wheels[0].GetComponent<Rotate>().enabled = true;
            Wheels[1].GetComponent<Rotate>().enabled = true;
            Wheels[2].GetComponent<Rotate>().enabled = true;
            Wheels[3].GetComponent<Rotate>().enabled = true;
        }
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")) /*|| other.gameObject.CompareTag("player") || other.gameObject.CompareTag("player"))*/
        {

            this.transform.GetComponent<splineMove>().Pause();
           // gameplay.instance.Traffic();
            GetComponent<AudioSource>().PlayOneShot(Collect);
            //foreach (GameObject w in Wheels)
            //{
            //    w.GetComponent<Rotate>().enabled = false;
            //}
            Wheels[0].GetComponent<Rotate>().enabled = false;
            Wheels[1].GetComponent<Rotate>().enabled = false;
            Wheels[2].GetComponent<Rotate>().enabled = false;
            Wheels[3].GetComponent<Rotate>().enabled = false;


        }
      
    }
    IEnumerator OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))/* || other.gameObject.CompareTag("player") || other.gameObject.CompareTag("player"))*/
        {
            yield return new WaitForSeconds(6.5f);
            this.transform.GetComponent<splineMove>().Resume();
            foreach (GameObject w in Wheels)
            {
                w.GetComponent<Rotate>().enabled = true;
            }
        }
    }
    public void Stoping()
    {
        //    foreach (GameObject w in Wheels)
        //    {
        //        w.GetComponent<Rotate>().enabled = false;
        //    }
        Wheels[0].GetComponent<Rotate>().enabled = false;
        Wheels[1].GetComponent<Rotate>().enabled = false;
        Wheels[2].GetComponent<Rotate>().enabled = false;
        Wheels[3].GetComponent<Rotate>().enabled = false;
    }


}
