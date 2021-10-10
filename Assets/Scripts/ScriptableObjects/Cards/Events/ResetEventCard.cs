using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects.Cards.Events
{
    [CreateAssetMenu(fileName = "ResetEventCard", menuName = "Scriptable/Card/Event/Reset", order = 0)]
    public class ResetEventCard : AEventCard
    {
        public override void RunEffect()
        {
            Body.ResetBody();
        }
    }
}