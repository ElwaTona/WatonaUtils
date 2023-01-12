using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Watona.Events;

namespace Watona.WatonaEditor
{
    public abstract class GameEventEditor<T> : Editor
    {
        public T Arguments;
        public SerializedObject SerializedObject;
        public SerializedProperty ArgumentProperty;
        public void OnEnable()
        {
            SerializedObject = new SerializedObject(this);
        }
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            GUI.enabled = true;

            EditorGUI.BeginChangeCheck();
            ArgumentProperty = SerializedObject.FindProperty("Arguments");
            Debug.Log(ArgumentProperty.editable);

            EditorGUILayout.PropertyField(ArgumentProperty);

            BaseGameEvent<T> e = target as BaseGameEvent<T>;

            if(GUILayout.Button("Raise"))
            {
                e.Raise(Arguments);
            }

            SerializedObject.ApplyModifiedProperties();
        }
    }
}
