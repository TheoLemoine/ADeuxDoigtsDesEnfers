using UnityEngine;
namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Compare Left Right Amount", order = 1)]
    public class CompareLeftRigthNumberDoorCard : ADoorCard
    {

        [SerializeField] private Members memberInvolved;
        [SerializeField] private bool rightHasLess = false;
        [SerializeField] private bool rightHasEqual = true;
        [SerializeField] private bool rightHasMore = false;

        public override bool CanGoThrough()
        {
            int numberLeft = 0;
            int numberRight = 0;
            if (memberInvolved == Members.Finger)
            {
                numberLeft = Body.instance.numberLeftFingers();
                numberRight = Body.memberCount(Members.Finger) - numberLeft;
            }
            else
            {
                Debug.LogWarning("Should not be used this way, or more code needs to be done ...");
                return false;
            }
            return (rightHasLess && (numberRight < numberLeft))
                || (rightHasEqual && (numberRight == numberLeft))
                || (rightHasMore && (numberRight > numberLeft));
        }
    }
}