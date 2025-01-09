using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLightsOff : MonoBehaviour
{
    public GameObject[] LightDim,LightDark;
    // Start is called before the first frame update
    void OnEnable()
    {
        LightDim[store.carNumber-1].SetActive(false);
        LightDark[store.carNumber-1].SetActive(false);
    }

    // Update is called once per frame
   
}
