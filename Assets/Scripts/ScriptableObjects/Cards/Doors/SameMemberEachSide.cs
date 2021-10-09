using UnityEngine;
namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Same Amount Member Each Side", order = 1)]
    public class SameMemberEachSide : ADoorCard
    {

        public override bool CanGoThrough()
        {
            int leftArms = Body.instance.numberLeftArm();
            int rightArms = Body.memberCount(Members.Arm) - leftArms;
            int leftLegs = Body.instance.numberLeftLegs();
            int rigthLegs = Body.memberCount(Members.Leg) - leftLegs;
            return leftLegs == rigthLegs && leftArms == rightArms;
        }
    }
}