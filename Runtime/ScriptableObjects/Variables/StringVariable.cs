// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;

namespace Watona.Variables
{
    [CreateAssetMenu(menuName = "Variable/String")]
    public class StringVariable : ScriptableObject
    {
        [SerializeField, TextArea]
        private string value = "";
#if UNITY_EDITOR
        [TextArea]
        public string DeveloperDescription = "";
#endif

        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}