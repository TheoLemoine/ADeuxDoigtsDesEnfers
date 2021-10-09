using UnityEngine;

namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Total number of limb", order = 0)]
    public class TotalLimbDoorCard : ADoorCard
    {
        [SerializeField] private int nbLimbNeeded = 8;

        public override bool CanGoThrough()
        {
            return Body.memberCount(Members.Arm) + Body.memberCount(Members.Leg) == nbLimbNeeded;
        }
    }
}