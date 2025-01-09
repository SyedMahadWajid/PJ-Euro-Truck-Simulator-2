using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FPSBoost : MonoBehaviour
{
    // Set the target frame rate
    public int targetFrameRate = 60;

    void Awake()
    {
        // Set the target frame rate
        Application.targetFrameRate = targetFrameRate;
    }

    void Update()
    {
        // If the current frame rate is lower than the target frame rate, increase the time scale
        if (Time.timeScale < 1.0f && Time.deltaTime < (1.0f / targetFrameRate))
        {
            Time.timeScale += 0.01f;
        }
        // If the current frame rate is higher than the target frame rate, decrease the time scale
        else if (Time.timeScale > 1.0f)
        {
            Time.timeScale -= 0.01f;
        }
    }
}

