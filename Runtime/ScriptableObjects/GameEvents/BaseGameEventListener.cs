using UnityEngine;
using UnityEngine.Events;

namespace Watona.Events
{
    public interface IEventListener<TParameter>
    {
        void RaiseEvent(TParameter parameter);
    }
    public abstract class BaseGameEventListener<TParameter, TGameEvent, TUnityEvent> : MonoBehaviour, IEventListener<TParameter>
        where TGameEvent : BaseGameEvent<TParameter>
        where TUnityEvent : UnityEvent<TParameter>
    {
        public TGameEvent GameEvent;
        public TUnityEvent Response;
    
        private void OnEnable()
        {
            GameEvent.RegisterListener(this);
        }
    
        private void OnDisable()
        {
            GameEvent.UnRegisterListener(this);
        }
    
        public void RaiseEvent(TParameter t)
        {
            Response.Invoke(t);
        }
    }
}
