// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;

namespace Watona.Variables
{
    [CreateAssetMenu(menuName = "Variable/Int")]
    public class IntVariable : ScriptableObject
    {
        public int Value;
#if UNITY_EDITOR
        [TextArea]
        public string DeveloperDescription = "";
#endif

        public void SetValue(int value)
        {
            Value = value;
        }

        public void SetValue(IntVariable value)
        {
            Value = value.Value;
        }

        public void ApplyChange(int amount)
        {
            Value += amount;
        }

        public void ApplyChange(IntVariable amount)
        {
            Value += amount.Value;
        }
    }
}