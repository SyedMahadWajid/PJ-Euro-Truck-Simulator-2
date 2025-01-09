using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;

public class AutoScrollPanel : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float scrollSpeed = 100.0f; // Adjust the scroll speed as needed
    private bool isScrolling = false;
    private float targetScrollValue = 1.0f; // Set the target scroll value to 1 (to scroll to the end)

    private void Update()
    {
        if (isScrolling)
        {
            // Calculate the current scroll position
            float currentScrollValue = scrollRect.horizontalScrollbar.value;

            // Interpolate towards the target scroll position
            currentScrollValue = Mathf.MoveTowards(currentScrollValue, targetScrollValue, scrollSpeed * Time.deltaTime);

            // Update the scroll position
            scrollRect.horizontalScrollbar.value = currentScrollValue;

            // Check if we reached the target scroll value
            if (Mathf.Approximately(currentScrollValue, targetScrollValue))
            {
                // Stop scrolling
                isScrolling = false;
            }
        }
    }

    public void StartAutoScroll()
    {
        // Start scrolling the panel horizontally
        isScrolling = true;
    }
}
