using UnityEngine;

namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Arm with N Finger", order = 0)]
    public class ArmWithNFingerDoorCard : ADoorCard
    {
        [SerializeField] private int nbFingerNeeded = 0;

        public override bool CanGoThrough()
        {
            foreach (Arm arm in Body.instance.arms)
            {
                if (arm.active)
                {
                    int numberOfActiveFinger = 0;
                    foreach (Finger finger in arm.fingers)
                    {
                        if (finger.active) numberOfActiveFinger++;
                    }
                    if (numberOfActiveFinger == nbFingerNeeded) return true;
                }
            }
            return false;
        }
    }
}