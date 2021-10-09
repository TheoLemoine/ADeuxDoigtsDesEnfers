using UnityEngine;
namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Two Five Fingered Hand", order = 1)]
    public class TwoHandFiveFingerDoorCard : ADoorCard
    {

        public override bool CanGoThrough()
        {
            int numberOfFiveFingeredHand = 0;
            foreach (Arm arm in Body.instance.arms)
            {
                if (arm.active)
                {
                    int nbFinger = 0;
                    foreach (Finger finger in arm.fingers)
                    {
                        if (finger.active)
                            nbFinger++;
                    }
                    if (nbFinger == 5)
                    {
                        numberOfFiveFingeredHand++;
                    }
                }
            }
            return numberOfFiveFingeredHand >= 2;
        }
    }
}