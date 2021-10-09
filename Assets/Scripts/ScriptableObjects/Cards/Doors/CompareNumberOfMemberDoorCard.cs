using UnityEngine;
namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Compare Member Amount", order = 1)]
    public class CompareNumberOfMemberDoorCard : ADoorCard
    {

        [SerializeField] private Members firstMemberInvolved;
        [SerializeField] private bool less = false;
        [SerializeField] private bool equal = true;
        [SerializeField] private bool more = false;
        [SerializeField] private Members secondMemberInvolved;

        public override bool CanGoThrough()
        {
            int numberFirst = Body.memberCount(firstMemberInvolved);
            int numberSecond = Body.memberCount(secondMemberInvolved);
            return (less && (numberFirst < numberSecond))
                || (equal && (numberFirst == numberSecond))
                || (more && (numberFirst > numberSecond));
        }
    }
}