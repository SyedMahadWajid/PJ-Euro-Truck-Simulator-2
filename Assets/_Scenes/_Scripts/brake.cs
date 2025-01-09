using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brake : MonoBehaviour
{

    public GameObject[] Car;

    public void BrakeStart(){
        Car[store.carNumber-1].GetComponent<Rigidbody>().drag = 2.5f;
    }
    public void BrakeEnd(){
        Car[store.carNumber-1].GetComponent<Rigidbody>().drag = 0.01f;
    }
}
