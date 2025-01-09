using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PLAYER2 : MonoBehaviour
{
    public GameObject colideeffect, failp, complatep;


    void Start()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "traffic")
        {
            colideeffect.SetActive(true);
            StartCoroutine(fail());
            GameObject.FindGameObjectWithTag("explode").gameObject.GetComponent<AudioSource>().Play();

        }
        if (collision.gameObject.tag == "traffic1")
        {
            this.gameObject.GetComponent<WaypointMover>().Pause();
        }


    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            this.gameObject.GetComponent<WaypointMover>().Pause();
            other.gameObject.GetComponent<WaypointMover>().Pause();
        }
    }

    IEnumerator fail()
    {
        yield return new WaitForSeconds(2f);
        AudioListener.volume = 0;
        failp.SetActive(true);
        Time.timeScale = 0;
    }
}

