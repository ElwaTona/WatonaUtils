using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Watona.Utils.Toolkit
{
    public class ToolkitUtils
    {
        public static void ChangeFiller(VisualElement filler, float current, float max)
        {
            float percentage = (current/max) * 100;
            if (percentage > 100)
                percentage = 100;
            filler.style.width = new StyleLength(Length.Percent(percentage));
        }
    }
}
