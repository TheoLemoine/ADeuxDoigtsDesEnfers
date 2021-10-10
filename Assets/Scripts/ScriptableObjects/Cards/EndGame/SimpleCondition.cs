using System;

namespace ScriptableObjects.Cards.EndGame
{
    [Serializable]
    public struct SimpleCondition
    {
        public Members neededMember;
        public int neededAmount;

        public bool IsValid() => Body.memberCount(neededMember) >= neededAmount;
    }
}