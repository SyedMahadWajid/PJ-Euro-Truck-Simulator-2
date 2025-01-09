using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutoCenterImage : MonoBehaviour
{
    public Transform imageToCenter;
    public float scrollSpeed = 5.0f;

    private Vector3 targetPosition;
    private bool isScrolling = false;

    private void Start()
    {
        // Check if the imageToCenter variable is assigned.
        if (imageToCenter == null)
        {
            Debug.LogError("Image to center is not assigned!");
            return;
        }

        // Calculate the target position at the center of the screen.
        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 10));

        // Initially, set the image's position to the target position.
        imageToCenter.position = targetPosition;
    }

    private void Update()
    {
        if (isScrolling)
        {
            // Smoothly interpolate the image's position towards the target position.
            imageToCenter.position = Vector3.Lerp(imageToCenter.position, targetPosition, scrollSpeed * Time.deltaTime);

            // Check if the image is close enough to the target position.
            if (Vector3.Distance(imageToCenter.position, targetPosition) < 0.01f)
            {
                // Stop scrolling when the image is close to the center.
                isScrolling = false;
            }
        }
    }

    public void ScrollToCenter()
    {
        // Start scrolling the image to the center.
        isScrolling = true;
    }
}

