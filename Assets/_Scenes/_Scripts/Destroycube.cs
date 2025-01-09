using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroycube : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<BoxCollider>().enabled = false;
    }


}
