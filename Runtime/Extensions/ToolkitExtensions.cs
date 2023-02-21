using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Watona.Utils
{
    public static class ToolkitExtensions
    {
        public static VisualElement SetPosition(this VisualElement bar, Transform transformToFollow, Camera mainCamera)
        {
            Vector2 newPosition = RuntimePanelUtils.CameraTransformWorldToPanel(bar.panel, transformToFollow.position, mainCamera);

            bar.transform.position = newPosition.WithNewX(newPosition.x - bar.layout.width / 2);
            return bar;
        }
        public static VisualElement ChangeFiller(this VisualElement filler, float current, float max)
        {
            float percentage = 0;
            percentage = percentage >= 100 ? 100 : (current/max) * 100;
            filler.style.width = new StyleLength(Length.Percent(percentage));
            return filler;
        }
        public static VisualElement SetVisibility(this VisualElement visualElement, bool value)
        {
            visualElement.style.display = value ? DisplayStyle.Flex : DisplayStyle.None;
            return visualElement;
        }
    }
}
