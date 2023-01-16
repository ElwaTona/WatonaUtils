using UnityEngine;
using UnityEngine.Events;
using System;

namespace Watona.Events
{
    [Serializable]
    public class CodedEventListener : IEventListener 
    {
        [SerializeField] private GameEvent @event;
        [SerializeField] private Action Response;
        public void OnEventRaised()
        {
            Response.Invoke();
        }
        public void OnEnable(Action response)
        {
            if(@event != null) @event.RegisterListener(this);
            Response = response;
        }
        public void OnDisable()
        {
            if(@event != null) @event.UnregisterListener(this);
            Response = null;
        }
    }
}
