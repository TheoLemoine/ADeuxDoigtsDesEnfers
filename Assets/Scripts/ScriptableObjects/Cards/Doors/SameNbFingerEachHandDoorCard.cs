using UnityEngine;
namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Same Number of Finger Each Hand", order = 1)]
    public class SameNbFingerEachHandDoorCard : ADoorCard
    {

        public override bool CanGoThrough()
        {
            int numberOfFingerFirstHand = -1;
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
                    if (numberOfFingerFirstHand == -1)
                    {
                        numberOfFingerFirstHand = nbFinger;
                    }
                    else
                    {
                        if (numberOfFingerFirstHand != nbFinger) return false;
                    }
                }
            }
            return true;
        }
    }
}