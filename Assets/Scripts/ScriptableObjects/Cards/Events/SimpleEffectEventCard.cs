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
                    Cutter.CutMemberAtRandom(effect.member, -effect.value);
                } 
                else if (effect.value > 0)
                {
                    Grower.GrowMemberAtRandom(effect.member, effect.value);
                }
            }
        }
    }
}