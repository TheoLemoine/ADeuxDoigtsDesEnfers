using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemberCollider : MonoBehaviour
{
    public Member member;
    private void OnMouseUpAsButton()
    {
        member.Cut();
    }
}
