using UnityEngine;
using System.ComponentModel;

namespace Watona.Variables
{
    public abstract class Variable<T> : ScriptableObject, INotifyPropertyChanged
    {
        [SerializeField]
        protected T value;
#if UNITY_EDITOR
        [TextArea]
        public string DeveloperDescription = "";
#endif
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public T Value
        {
            get { return value; }
            set { this.value = value; OnPropertyChanged(nameof(Value)); }
        }

        public void SetValue(T value)
        {
            Value = value;
        }
        public void SetValue(Variable<T> variable)
        {
            Value = variable.Value;
        }

        public void SetValueWithoutNotify(T value)
        {
            this.value = value;
        }
        public void SetValueWithoutNotify(Variable<T> variable)
        {
            value = variable.Value;
        }
    }
}