using UnityEngine;

namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/No Right or Left arm", order = 0)]
    public class NoRightLeftArmDoorCard : ADoorCard
    {
        [SerializeField] private bool noRightArms = true;

        public override bool CanGoThrough()
        {
            int numberLeftArm = Body.instance.numberLeftArm();
            if (noRightArms)
            {
                return Body.memberCount(Members.Arm) == numberLeftArm;
            }
            return numberLeftArm == 0;
        }
    }
}