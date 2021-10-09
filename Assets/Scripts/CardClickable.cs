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

    [HideInInspector] public Vector3 discardPos;
    [HideInInspector] public Vector3 usePos;

    private bool _clickActive = true;
    
    private void Start()
    {
        discardOn.OnTriggered += DoDiscardCard;
    }

    private IEnumerator OnMouseUpAsButton()
    {
        if (!_clickActive) yield break;
        _clickActive = false;

        discardOn.OnTriggered -= DoDiscardCard;
        
        discardOn.Trigger();
        
        lerper.targetPos = usePos;

        yield return new WaitForSeconds(2);
        
        cardData.card.RunEffect();
        // set narration text

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
        // do hover effect
    }

    private void OnMouseExit()
    {
        // stop hover effect
    }

    private void Update()
    {
        // update usability
    }

    private void DoDiscardCard()
    {
        StartCoroutine(DiscardCard());
    }
    
    private IEnumerator DiscardCard()
    {
        _clickActive = false;
        discardOn.OnTriggered -= DoDiscardCard;
        
        yield return new WaitForSeconds(0.2f);
        
        lerper.targetPos = discardPos;
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}