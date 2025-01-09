using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class truckcustomization : MonoBehaviour
{

    public GameObject[] hoods, grillights, monuments, steelframes, headlightframes, interior_lights, curtains,trucks;
   

    void Start()
    {
        string cuurentTruckHood = string.Concat(store.carNumber - 1 + "truck_currentHood");
        string hoodPref = string.Concat(PlayerPrefs.GetInt(cuurentTruckHood).ToString() + "_hoodLockTruck_" + (store.carNumber - 1).ToString());
        if (PlayerPrefs.GetInt(hoodPref) == 1)
            hoods[PlayerPrefs.GetInt(cuurentTruckHood)].SetActive(true);

        string curentTrucksteel = string.Concat(store.carNumber - 1 + "truck_currentsteel");
        string steelframePref = string.Concat(PlayerPrefs.GetInt(curentTrucksteel).ToString() + "_steelLockTruck_" + (store.carNumber - 1).ToString());
        if (PlayerPrefs.GetInt(steelframePref) == 3)
            steelframes[PlayerPrefs.GetInt(curentTrucksteel)].SetActive(true);

        string cuurentTruckGrills = string.Concat(store.carNumber - 1 + "truck_currentGrill");
        string grillPref = string.Concat(PlayerPrefs.GetInt(cuurentTruckGrills).ToString() + "_GrillLockTruck_" + (store.carNumber - 1).ToString());
        if (PlayerPrefs.GetInt(grillPref) == 2)
            grillights[PlayerPrefs.GetInt(cuurentTruckGrills)].SetActive(true);

        string curentTruckheadlight = string.Concat(store.carNumber - 1 + "truck_currentheadlight");
        string headlightPref = string.Concat(PlayerPrefs.GetInt(curentTruckheadlight).ToString() + "_headlightLocktruck_" + (store.carNumber - 1).ToString());
        if (PlayerPrefs.GetInt(headlightPref) == 4)
            headlightframes[PlayerPrefs.GetInt(curentTruckheadlight)].SetActive(true);

        string curentTruckilight = string.Concat(store.carNumber - 1 + "truck_currentilight");
        string ilightPref = string.Concat(PlayerPrefs.GetInt(curentTruckilight).ToString() + "_ilightLocktruck_" + (store.carNumber - 1).ToString());
        if (PlayerPrefs.GetInt(ilightPref) == 5)
            interior_lights[PlayerPrefs.GetInt(curentTruckilight)].SetActive(true);
    }
}
