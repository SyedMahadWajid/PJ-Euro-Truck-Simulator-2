using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScrollToCenter : MonoBehaviour
{
    public ScrollRect scrollRect;
    public RectTransform targetItem;

    public void ScrollToSelectedItem()
    {
        if (scrollRect != null && targetItem != null)
        {
            // Calculate the normalized position of the target item
            float normalizedPosition = CalculateNormalizedPosition();

            // Set the scroll position to center the target item
            scrollRect.horizontalNormalizedPosition = normalizedPosition;
            scrollRect.verticalNormalizedPosition = normalizedPosition;
        }
    }

    private float CalculateNormalizedPosition()
    {
        // Calculate the position of the target item relative to the scroll view's content
        Vector3 targetItemLocalPos = scrollRect.content.InverseTransformPoint(targetItem.position);

        // Calculate the normalized position based on the target item's position
        float normalizedPosition = 0f;

        if (scrollRect.horizontal)
        {
            float contentWidth = scrollRect.content.rect.width - scrollRect.viewport.rect.width;
            normalizedPosition = Mathf.Clamp01(targetItemLocalPos.x / contentWidth);
        }
        else if (scrollRect.vertical)
        {
            float contentHeight = scrollRect.content.rect.height - scrollRect.viewport.rect.height;
            normalizedPosition = Mathf.Clamp01(targetItemLocalPos.y / contentHeight);
        }

        return normalizedPosition;
    }
}
