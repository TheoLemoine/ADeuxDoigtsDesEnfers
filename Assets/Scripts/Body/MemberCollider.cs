using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class MemberCollider : MonoBehaviour
{
    public bool isActiveByDefault;
    public Member member;
    private void OnMouseUpAsButton()
    {
        member.Cut();
    }
}
