namespace ScriptableObjects.Cards.Events
{
    public abstract class AEventCard : ACard
    {
        public override bool CanGoThrough() => true;
    }
}