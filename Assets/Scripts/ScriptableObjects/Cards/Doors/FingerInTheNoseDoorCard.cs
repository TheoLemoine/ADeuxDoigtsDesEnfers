using UnityEngine;

namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Finger In The Nose", order = 0)]
    public class FingerInTheNoseDoorCard : ADoorCard
    {
        public override bool CanGoThrough()
        {
            if (Body.memberCount(Members.Nose) == 0)
            {
                return false;
            }
            foreach (Arm arm in Body.instance.arms)
            {
                if (arm.active)
                {
                    int numberOfActiveFinger = 0;
                    foreach (Finger finger in arm.fingers)
                    {
                        if (finger.active) numberOfActiveFinger++;
                    }
                    if (numberOfActiveFinger == 2) return true;
                }
            }
            return false;
        }
    }
}