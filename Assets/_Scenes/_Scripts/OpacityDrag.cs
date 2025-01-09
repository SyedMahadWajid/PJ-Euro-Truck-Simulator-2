using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sure! Here 's an example of how you can achieve that in Unity using C#:


using UnityEngine.UI;

public class OpacityDrag : MonoBehaviour
{
    public float fadeSpeed = 0.5f;
    public float originalOpacity = 1f;

    private bool isDragging = false;
    private float currentOpacity;
    private Image panel;
    private Button[] buttons;

    private void Start()
    {
        panel = GetComponent<Image>();
        buttons = GetComponentsInChildren<Button>();
        currentOpacity = originalOpacity;
    }

    private void Update()
    {
        if (isDragging)
        {
            currentOpacity -= fadeSpeed * Time.deltaTime;
            SetOpacity(currentOpacity);
        }
        else if (currentOpacity < originalOpacity)
        {
            currentOpacity += fadeSpeed * Time.deltaTime;
            SetOpacity(currentOpacity);
        }
    }

    private void SetOpacity(float opacity)
    {
        Color panelColor = panel.color;
        panelColor.a = opacity;
        panel.color = panelColor;

        foreach (Button button in buttons)
        {
            Color buttonColor = button.image.color;
            buttonColor.a = opacity;
            button.image.color = buttonColor;
        }
    }

    public void OnDrag()
    {
        isDragging = true;
    }

    public void OnRelease()
    {
        isDragging = false;
    }
}


