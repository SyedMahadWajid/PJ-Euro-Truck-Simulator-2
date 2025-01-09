using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;

public class PanelOpacityController : MonoBehaviour
{
    public float dragOpacity = 0.0f;          // Opacity during drag
    public float originalOpacity = 1.0f;      // Original opacity
    public float opacityChangeSpeed = 0.1f;   // Speed of opacity change

    private CanvasGroup canvasGroup;

    private void Start()
    {
        // Ensure we have a CanvasGroup component
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
    }

    public void OnDrag()
    {
        // Set opacity to drag opacity
        SetOpacity(dragOpacity);
    }

    public void OnRelease()
    {
        // Set opacity to original opacity with a particular speed
        StartCoroutine(LerpOpacity(originalOpacity));
    }

    private void SetOpacity(float opacity)
    {
        canvasGroup.alpha = opacity;
    }

    private IEnumerator LerpOpacity(float targetOpacity)
    {
        float currentOpacity = canvasGroup.alpha;

        while (currentOpacity != targetOpacity)
        {
            currentOpacity = Mathf.Lerp(currentOpacity, targetOpacity, opacityChangeSpeed);
            SetOpacity(currentOpacity);
            yield return null;
        }
    }
}

