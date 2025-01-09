using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanechangescrit : MonoBehaviour
{

    public GameObject waypoint1, waypoint2,waypoint3,playerl2;
    public GameObject[] player, playerlane2,playerlevel10;
        

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "turn")
        {
            
           this.GetComponent<WaypointMover>().waypointsHolder = waypoint2.GetComponent<WaypointsHolder>();
            

        }
        if (other.gameObject.tag == "turn2")
        {

            this.GetComponent<WaypointMover>().waypointsHolder = waypoint3.GetComponent<WaypointsHolder>();


        }
        if (other.gameObject.tag == "straight")
        {

            this.GetComponent<WaypointMover>().waypointsHolder = waypoint3.GetComponent<WaypointsHolder>();


        }

    }
   public void Start()
    {
        StartCoroutine(Level3());
        StartCoroutine(Level4());
        StartCoroutine(Level10());
        //if (MenuScene.trafiiclevel == 9)
        //{
            
        //}
    }
    IEnumerator Level3()
    {
        yield return new WaitForSeconds(10f);
        player[1].SetActive(true);
        player[2].SetActive(true);
        yield return new WaitForSeconds(10f);
        player[3].SetActive(true);
        player[4].SetActive(true);
        yield return new WaitForSeconds(15f);
        playerl2.SetActive(true);
    }
    IEnumerator Level4()
    {
        yield return new WaitForSeconds(10f);
        playerlane2[0].SetActive(true);
        playerlane2[1].SetActive(true);
        yield return new WaitForSeconds(10f);
        playerlane2[2].SetActive(true);
        playerlane2[3].SetActive(true);

    }
    IEnumerator Level10()
    {
        yield return new WaitForSeconds(12f);
        playerlevel10[0].SetActive(true);
        playerlevel10[1].SetActive(true);
        playerlevel10[2].SetActive(true);
        yield return new WaitForSeconds(12f);
        playerlevel10[3].SetActive(true);
        playerlevel10[4].SetActive(true);
        playerlevel10[5].SetActive(true);

    }

}
