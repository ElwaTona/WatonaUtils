// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

namespace Watona.Events
{
    [CreateAssetMenu(menuName = "Event/Event")]
    public class GameEvent : ScriptableObject
    {
        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<IEventListener> listeners = new List<IEventListener>();

        public void Raise()
        {
            for(int i = listeners.Count -1; i >= 0; i--) listeners[i].OnEventRaised();
        }

        public void RegisterListener(IEventListener listener)
        {
            if (!listeners.Contains(listener)) listeners.Add(listener);
        }

        public void UnregisterListener(IEventListener listener)
        {
            if (listeners.Contains(listener)) listeners.Remove(listener);
        }
    }
}