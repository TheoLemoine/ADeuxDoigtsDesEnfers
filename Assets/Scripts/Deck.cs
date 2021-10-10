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
        var nbCard = 1;

        foreach (var targetTransform in cardPosition)
        {
            var isLast = nbCard == cardPosition.Count;
            DrawCard(
                targetTransform.position + new Vector3(
                    Random.Range(-0.2f, 0.2f), 
                    Random.Range(-0.2f, 0.2f), 
                    Random.Range(-0.2f, 0.2f)
                    ), 
                isLast,
                nbCard,
                ref drawnCards
                );

            nbCard++;

            yield return new WaitForSeconds(0.5f);
        }
    }

    private void DrawCard(Vector3 position, bool drawDefault, int zpos, ref List<ACard> alreadyDrawnCard)
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
        cardGO.transform.position += Vector3.back * zpos;

        var cardDataSetter = cardGO.GetComponent<CardDataSetter>();
        cardDataSetter.card = drawnCard;

        var lerper = cardGO.GetComponent<LerpToPos>();
        lerper.targetPos = position;

        var clickable = cardGO.GetComponent<CardClickable>();
        clickable.usePos = usedPile.position;
        clickable.discardPos = discardedPile.position;
    }
}