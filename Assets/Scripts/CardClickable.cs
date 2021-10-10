using System.Collections;
using ScriptableObjects;
using ScriptableObjects.Cards.Doors;
using ScriptableObjects.Cards.Events;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class CardClickable : MonoBehaviour
{
    [SerializeField] private EventBus drawEvents;
    [SerializeField] private EventBus drawDoors;
    [SerializeField] private EventBus discardOn;
    [SerializeField] private CardDataSetter cardData;
    [SerializeField] private LerpToPos lerper;
    [SerializeField] private SpriteRenderer unavailableMask;

    [HideInInspector] public Vector3 discardPos;
    public Vector3 usePos = new Vector3(4.14f, 7.59f, 0f);

    private bool _clickActive = true;
    private bool _isHovered = false;
    
    private void Start()
    {
        discardOn.OnTriggered += DoDiscardCard;
    }

    private IEnumerator OnMouseUpAsButton()
    {
        // on click
        if (!_clickActive) yield break;
        _clickActive = false;

        // discard all other cards
        discardOn.OnTriggered -= DoDiscardCard;
        discardOn.Trigger();
        
        // move the card out
        lerper.targetPos = usePos;

        yield return new WaitForSeconds(1);
        
        // card effect
        cardData.card.RunEffect();
        
        // TODO set narration text
        Narration.SetText(cardData.card.narrationText);

        // next turn
        if (cardData.card is ADoorCard)
        {
            drawEvents.Trigger();
        }
        else if (cardData.card is AEventCard)
        {
            drawDoors.Trigger();
        }
        
        Destroy(gameObject);
    }

    private void OnMouseEnter()
    {
        if(!_clickActive) return;
        _isHovered = true;
    }

    private void OnMouseExit()
    {
        _isHovered = false;
    }

    private void Update()
    {
        var canGoThrough = cardData.card.CanGoThrough();
        _clickActive = canGoThrough;
        unavailableMask.enabled = !canGoThrough;
        
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one * (_isHovered ? 1.1f : 1f), 0.1f);
    }

    private void DoDiscardCard()
    {
        StartCoroutine(DiscardCard());
    }
    
    private IEnumerator DiscardCard()
    {
        // move the card out and destroy it
        _clickActive = false;
        discardOn.OnTriggered -= DoDiscardCard;
        
        yield return new WaitForSeconds(0.2f);
        
        lerper.targetPos = discardPos;
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}