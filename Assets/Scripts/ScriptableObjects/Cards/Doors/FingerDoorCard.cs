using UnityEngine;

namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/FingerDoor", order = 0)]
    public class FingerDoorCard : ADoorCard
    {
        [SerializeField] private int nbFingerNeeded = 5;
        
        public override bool CanGoThrough()
        {
            // TODO use Body class to check if number of finger is good
            return false;
        }
    }
}