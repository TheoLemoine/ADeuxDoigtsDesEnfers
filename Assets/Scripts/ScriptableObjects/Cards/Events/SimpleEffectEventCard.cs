using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Cards.Events
{
    [CreateAssetMenu(fileName = "EventCard", menuName = "Scriptable/Card/Event/SimpleEffect", order = 0)]
    public class SimpleEffectEventCard : AEventCard
    {
        [SerializeField] private List<SimpleEffect> effectList;
        
        public override void RunEffect()
        {
            foreach (var effect in effectList)
            {
                if (effect.value < 0)
                {
                    // cut members
                    Debug.Log($"Cutting {-effect.value} {effect.member}");
                } 
                else if (effect.value > 0)
                {
                    // grow members
                    Debug.Log($"Growing {effect.value} {effect.member}");
                }
            }
        }
    }
}