using UnityEngine;

namespace ScriptableObjects.Cards.EndGame
{
    public abstract class AEndGameCard : ACard
    {
        public override void RunEffect()
        {
            if (IsWin())
            {
                // Win
            }
            else
            {
                // Loose
            }
        }

        public abstract bool IsWin();
    }
}