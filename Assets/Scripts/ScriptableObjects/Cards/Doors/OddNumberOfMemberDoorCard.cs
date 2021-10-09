using UnityEngine;

namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Odd Number of Members", order = 0)]
    public class OddNumberOfMembersDoorCard : ADoorCard
    {
        [SerializeField] private Members member;

        public override bool CanGoThrough()
        {
            return (Body.memberCount(member) % 2) == 1;
        }
    }
}