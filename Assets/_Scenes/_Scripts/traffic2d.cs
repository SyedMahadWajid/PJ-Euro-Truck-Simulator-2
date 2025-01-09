using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class traffic2d : MonoBehaviour
    {
    
    public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "red")
            {
                //this.GetComponent<splineMove>().enabled = false;
                this.gameObject.GetComponent<WaypointMover>().Pause();
            }
            if (other.gameObject.tag == "green")
            {
                //this.GetComponent<splineMove>().enabled = false;
                this.gameObject.GetComponent<WaypointMover>().Unpause();
            }
        }
    
    }

