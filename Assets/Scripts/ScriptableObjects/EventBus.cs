using System;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Event", menuName = "Scriptable/Event Bus", order = 0)]
    public class EventBus : ScriptableObject
    {
        public event Action OnTriggered;

        public void Trigger()
        {
            OnTriggered?.Invoke();
        }
    }
}