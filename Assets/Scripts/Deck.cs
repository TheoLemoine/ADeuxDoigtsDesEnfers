using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ScriptableObjects;
using ScriptableObjects.Cards;
using UnityEngine;
using Random = UnityEngine.Random;

public class Deck : MonoBehaviour
{
    [SerializeField] private ACard defaultDrawnCard;
    [SerializeField] private EventBus drawOn;
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private List<ACard> cards;
    [SerializeField] private Transform startTransform;
    [SerializeField] private List<Transform> cardPosition;
    [SerializeField] private Transform usedPile;
    [SerializeField] private Transform discardedPile;

    private void Start()
    {
        drawOn.OnTriggered += () => StartCoroutine(DrawCards());
    }

    private IEnumerator DrawCards()
    {
        var drawnCards = new List<ACard>();

        foreach (var targetTransform in cardPosition)
        {
            var isLast = targetTransform == cardPosition.Last();
            DrawCard(
                targetTransform.position + new Vector3(
                    Random.Range(-0.2f, 0.2f), 
                    Random.Range(-0.2f, 0.2f), 
                    Random.Range(-0.2f, 0.2f)
                    ), 
                isLast,
                ref drawnCards
                );

            yield return new WaitForSeconds(0.5f);
        }
    }

    private void DrawCard(Vector3 position, bool drawDefault, ref List<ACard> alreadyDrawnCard)
    {
        ACard drawnCard;

        if (drawDefault)
        {
            drawnCard = defaultDrawnCard;
        }
        else
        {
            do
            {
                drawnCard = cards[Random.Range(0, cards.Count)];
            } while (alreadyDrawnCard.Contains(drawnCard));
        }

        var cardGO = Instantiate(cardPrefab, startTransform.position, Quaternion.identity);

        var cardDataSetter = cardGO.GetComponent<CardDataSetter>();
        cardDataSetter.card = drawnCard;

        var lerper = cardGO.GetComponent<LerpToPos>();
        lerper.targetPos = position;

        var clickable = cardGO.GetComponent<CardClickable>();
        clickable.usePos = usedPile.position;
        clickable.discardPos = discardedPile.position;
    }
}