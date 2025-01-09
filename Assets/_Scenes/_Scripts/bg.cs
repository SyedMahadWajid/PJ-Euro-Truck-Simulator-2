using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    public GameObject[] Bg;
    void OnEnable()
    {
        Bg[0].SetActive(true);
    }
    void OnDisable()
    {
        Bg[0].SetActive(false);
        Bg[1].SetActive(false);
        Bg[2].SetActive(false);
        Bg[3].SetActive(false);
    }

}
