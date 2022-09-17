using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Watona;

namespace Watona.Utils
{
    public static class ToolkitUtils
    {
        public static void ChangeFiller(VisualElement filler, float current, float max)
        {
            float percentage = (current/max) * 100;
            if (percentage > 100)
                percentage = 100;
            filler.style.width = new StyleLength(Length.Percent(percentage));
        }

        public static void SetPosition(VisualElement bar, Transform transformToFollow, Camera mainCamera)
        {
            Vector2 newPosition = RuntimePanelUtils.CameraTransformWorldToPanel(bar.panel, transformToFollow.position, mainCamera);

            bar.transform.position = newPosition.WithNewX(newPosition.x = bar.layout.width / 2);
        }
    }
}
