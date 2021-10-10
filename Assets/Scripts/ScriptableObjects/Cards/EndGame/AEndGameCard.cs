using UnityEngine;

namespace ScriptableObjects.Cards.EndGame
{
    public abstract class AEndGameCard : ACard
    {
        [SerializeField] private EventBus endGameEvent;
        
        public override void RunEffect()
        {
            endGameEvent.Trigger();
        }
    }
}