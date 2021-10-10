using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ScriptableObjects.Cards.EndGame
{
    [CreateAssetMenu(fileName = "Immortality card", menuName = "Scriptable/Card/EndGame/Immortality card", order = 0)]
    public class ImmortalityCard : AEndGameCard
    {
        [SerializeField] private List<SimpleCondition> conditions;
        
        public override bool IsWin() => true;

        public override bool CanGoThrough() => conditions.All(c => c.IsValid());
    }
}