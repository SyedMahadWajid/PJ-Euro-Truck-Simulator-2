using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterSelectedImage : MonoBehaviour
{
    public Image selectedImage;

    private void Start()
    {
        if (selectedImage == null)
        {
            Debug.LogError("Selected Image is not assigned!");
            return;
        }

        // Get the screen width and height.
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        // Get the RectTransform of the selected image.
        RectTransform imageRect = selectedImage.GetComponent<RectTransform>();

        // Calculate the center position of the screen.
        Vector2 centerPosition = new Vector2(screenWidth / 2f, screenHeight / 2f);

        // Set the selected image's position to the center of the screen.
        imageRect.position = centerPosition;
    }
}

