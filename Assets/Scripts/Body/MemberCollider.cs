using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class MemberCollider : MonoBehaviour
{
    public Member member;
    private void OnMouseUpAsButton()
    {
        member.Cut();
    }
}
