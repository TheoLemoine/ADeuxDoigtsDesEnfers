using UnityEditor;
using UnityEngine;

namespace ScriptableObjects.Editor
{
    [CustomEditor(typeof(EventBus))]
    public class EventBusEditor : UnityEditor.Editor
    {
        private EventBus eventBus;

        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Trigger"))
            {
                eventBus = (EventBus) target;
                eventBus.Trigger();
            }

            base.OnInspectorGUI();
        }
    }
}