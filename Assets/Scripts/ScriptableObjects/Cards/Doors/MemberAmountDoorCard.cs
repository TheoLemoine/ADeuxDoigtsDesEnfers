using UnityEngine;
namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Member Amount", order = 1)]
    public class MemberAmountDoorCard : ADoorCard
    {

        [SerializeField] private Members memberInvolved;
        [SerializeField] private bool less = false;
        [SerializeField] private bool equal = true;
        [SerializeField] private bool more = false;
        [SerializeField] private int memberAmount = 0;

        [SerializeField] private bool isSecondMemberInvolved = false;
        [SerializeField] private Members secondMemberInvolved;
        [SerializeField] private bool less2 = false;
        [SerializeField] private bool equal2 = true;
        [SerializeField] private bool more2 = false;
        [SerializeField] private int secondMemberAmount = 0;


        public override bool CanGoThrough()
        {
            bool firstQualityCheck = false;
            bool secondQualityCheck = true;

            int firstMemberAnount = Body.memberCount(memberInvolved);
            firstQualityCheck = (less && (firstMemberAnount < memberAmount))
                                 || (equal && (firstMemberAnount == memberAmount))
                                 || (more && (firstMemberAnount > memberAmount));

            if (isSecondMemberInvolved)
            {
                int secondNumberActualAmount = Body.memberCount(secondMemberInvolved);
                secondQualityCheck = (less2 && (secondNumberActualAmount < secondMemberAmount))
                                 || (equal2 && (secondNumberActualAmount == secondMemberAmount))
                                 || (more2 && (secondNumberActualAmount > secondMemberAmount));
            }

            return firstQualityCheck && secondQualityCheck;
        }
    }
}