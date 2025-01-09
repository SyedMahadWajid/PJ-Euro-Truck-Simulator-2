using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollAndRepositionImage : MonoBehaviour
{
    public RectTransform panelRect;
    public RectTransform imageRect;
    public Vector2 selectedCenterAnchor;

    private Vector2 targetPosition;
    private bool isScrolling = false;

    private void Start()
    {
        // Calculate the initial target position for the image based on the selected center anchor.
        targetPosition = new Vector2(
            selectedCenterAnchor.x * panelRect.rect.width,
            selectedCenterAnchor.y * panelRect.rect.height
        );

        // Set the image's initial position to the target position.
        imageRect.anchoredPosition = targetPosition;
    }

    private void Update()
    {
        if (isScrolling)
        {
            // Smoothly interpolate the image's position towards the target position.
            imageRect.anchoredPosition = Vector2.Lerp(imageRect.anchoredPosition, targetPosition, 5f * Time.deltaTime);

            // Check if the image is close enough to the target position.
            if (Vector2.Distance(imageRect.anchoredPosition, targetPosition) < 0.01f)
            {
                // Stop scrolling when the image is close to the target position.
                isScrolling = false;
            }
        }
    }

    public void ScrollToSelectedCenter()
    {
        // Calculate the target position based on the selected center anchor.
        targetPosition = new Vector2(
            selectedCenterAnchor.x * panelRect.rect.width,
            selectedCenterAnchor.y * panelRect.rect.height
        );

        // Start scrolling the image to the selected center.
        isScrolling = true;
    }
}

