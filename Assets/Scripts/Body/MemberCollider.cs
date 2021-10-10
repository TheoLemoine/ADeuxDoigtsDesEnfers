using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class MemberCollider : MonoBehaviour
{
    public bool isActiveByDefault;
    public Member member;
    SpriteRenderer spriteRenderer;
    private void OnMouseUpAsButton()
    {
        SoundEffectHelper.instance.MakeCutingSound();
        member.Cut();
    }

    private void OnMouseOver()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        spriteRenderer.color = new Color(1, 0.5f, 0.5f, 1);
    }

    private void OnMouseExit()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        spriteRenderer.color = new Color(1, 1, 1, 1);
    }

    public void GoBackWhite()
    {
        OnMouseExit();
    }
}
