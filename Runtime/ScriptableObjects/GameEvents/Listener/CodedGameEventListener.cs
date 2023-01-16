using UnityEngine;
using UnityEngine.Events;
using System;

namespace Watona.Events
{
    [Serializable]
    public class CodedGameEventListener<T> : IEventListener<T> where T : struct
    {
        [SerializeField] private BaseGameEvent<T> @event;
        [SerializeField] private Action<T> Response;
        public void RaiseEvent(T args)
        {
            Response.Invoke(args);
        }
        public void OnEnable(Action<T> response)
        {
            if(@event != null) @event.RegisterListener(this);
            Response = response;
        }
        public void OnDisable()
        {
            if(@event != null) @event.UnRegisterListener(this);
            Response = null;
        }
    }
}
