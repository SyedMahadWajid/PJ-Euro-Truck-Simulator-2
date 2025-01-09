using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpacityControl1 : MonoBehaviour

{ 
    public CanvasGroup panelCanvasGroup;
    public Button[] buttons;
    public float fadeDuration = 0.5f;

    private float originalPanelAlpha;
    private float[] originalButtonAlphas;

    private void Start()
    {
        // Store the original alpha values
        originalPanelAlpha = panelCanvasGroup.alpha;
        originalButtonAlphas = new float[buttons.Length];
        for (int i = 0; i < buttons.Length; i++)
        {
            originalButtonAlphas[i] = buttons[i].GetComponent<CanvasGroup>().alpha;
        }
    }

    public void OnDrag(float normalizedOpacity)
    {
        SetOpacity(normalizedOpacity);
    }

    public void OnRelease()
    {
        SetOpacity(originalPanelAlpha, originalButtonAlphas);
    }

    private void SetOpacity(float panelAlpha, float[] buttonAlphas)
    {
        panelCanvasGroup.alpha = panelAlpha;
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<CanvasGroup>().alpha = buttonAlphas[i];
        }
    }

    private void SetOpacity(float normalizedOpacity)
    {
        panelCanvasGroup.alpha = Mathf.Lerp(0f, originalPanelAlpha, normalizedOpacity);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].GetComponent<CanvasGroup>().alpha = Mathf.Lerp(0f, originalButtonAlphas[i], normalizedOpacity);
        }
    }
}

