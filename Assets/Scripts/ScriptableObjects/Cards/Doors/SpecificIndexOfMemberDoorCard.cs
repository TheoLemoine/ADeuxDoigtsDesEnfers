using UnityEngine;

namespace ScriptableObjects.Cards.Doors
{
    [CreateAssetMenu(fileName = "DoorCard", menuName = "Scriptable/Card/Door/Specific Index of Member", order = 0)]
    public class SpecificIndexOfMemberDoorCard : ADoorCard
    {
        [SerializeField] private int index = 0;
        [SerializeField] private bool hasNot = true;
        [SerializeField] private bool hasOnly = false;
        [SerializeField] private Members member;

        public override bool CanGoThrough()
        {
            if (hasNot)
            {
                if (member == Members.Ear)
                    return !Body.instance.ears[index].active;
                Debug.LogWarning("Should not be used this way, or more code needs to be done ...");
                return false;
            }
            if (hasOnly)
            {
                if (member == Members.Eye)
                    return Body.instance.ears[index].active && (Body.memberCount(Members.Eye) == 1);
                Debug.LogWarning("Should not be used this way, or more code needs to be done ...");
                return false;
            }
            Debug.LogWarning("Should not be used this way, or more code needs to be done ...");
            return false;
        }
    }
}