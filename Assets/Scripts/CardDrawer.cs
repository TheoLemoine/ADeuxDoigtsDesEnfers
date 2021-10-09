using ScriptableObjects.Cards;
using TMPro;
using UnityEngine;

[ExecuteAlways]
public class CardDrawer : MonoBehaviour
{
    public ACard card;
    [SerializeField] private SpriteRenderer illustrationRenderer;
    [SerializeField] private TextMeshPro titleTMP;
    [SerializeField] private TextMeshPro effectTMP;

    private void Update()
    {
        if (card)
        {
            illustrationRenderer.sprite = card.image;
            titleTMP.text = card.title;
            effectTMP.text = card.effectText;
        }
    }
}