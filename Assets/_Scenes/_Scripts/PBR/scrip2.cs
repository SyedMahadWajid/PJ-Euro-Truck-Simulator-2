using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip2 : MonoBehaviour
{
    public truckObj[] trucks;
    void Start()
    {
        if (PlayerPrefs.GetInt("currentgrill") == 1)
        {
            print("prefrenceget1");
            trucks[store.carNumber - 1].grillLights[PlayerPrefs.GetInt("currentgrill")].SetActive(true);
        }
    }

    
}
