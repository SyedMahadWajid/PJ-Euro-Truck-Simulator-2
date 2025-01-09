using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
     public truckObj[] trucks;

    public void Start()
    {
        if (PlayerPrefs.GetInt("currentsteelframe") == 1)
        {
            print("prefs2");
            trucks[store.carNumber - 1].steelFrames[PlayerPrefs.GetInt("currentHood")].SetActive(true);
        }
    }
}
