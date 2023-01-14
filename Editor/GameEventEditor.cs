using UnityEngine;
using UnityEditor;
using Watona.Events;

namespace Watona.WatonaEditor
{
    public abstract class GameEventEditor<TParameter> : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUI.enabled = Application.isPlaying;

            BaseGameEvent<TParameter> e = target as BaseGameEvent<TParameter>;

            if(GUILayout.Button("Raise"))
            {
                e.Raise(e.Parameter);
            }
        }
    }
}
