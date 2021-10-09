using UnityEngine;

namespace ScriptableObjects.Cards.EndGame
{
    [CreateAssetMenu(fileName = "EndGameCard", menuName = "Scriptable/Card/EndGame/Hell gates", order = 0)]
    public class HellGates : AEndGameCard
    {
        public override bool IsWin() => false;
        public override bool CanGoThrough() => true;
    }
}