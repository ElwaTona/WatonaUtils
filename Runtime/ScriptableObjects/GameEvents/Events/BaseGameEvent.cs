using System.Collections.Generic;
using UnityEngine;

namespace Watona.Events
{
    public class BaseGameEvent<TParameter> : ScriptableObject
    {
        public TParameter Parameter => _parameter;
        [SerializeField] protected TParameter _parameter;
        [SerializeField] private List<IEventListener<TParameter>> _listeners = new List<IEventListener<TParameter>>();
    
        public void Raise(TParameter parameter)
        {
            _parameter = parameter;
            for (int i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].RaiseEvent(_parameter);
            }
        }
        public void RegisterListener(IEventListener<TParameter> listener)
        {
            if (!_listeners.Contains(listener)) { _listeners.Add(listener); }
        }
        public void UnRegisterListener(IEventListener<TParameter> listener)
        {
            if (_listeners.Contains(listener)) { _listeners.Remove(listener); }
        }
    }
}
