using UnityEngine;

namespace Watona.Variables
{
    public abstract class Variable<T> : ScriptableObject
    {
        [SerializeField]
        private T value;
#if UNITY_EDITOR
        [TextArea]
        public string DeveloperDescription = "";
#endif

        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public void SetValue(T value)
        {
            Value = value;
        }

        public void SetValue(Variable<T> variable)
        {
            Value = variable.Value;
        }
    }
}