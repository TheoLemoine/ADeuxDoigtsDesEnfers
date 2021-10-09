using UnityEngine;

namespace ScriptableObjects.Cards
{
    public abstract class ACard : ScriptableObject
    {
        // title of the card
        public string title;
        
        // image on the card
        public Sprite image;
        
        // text displayed on the card
        [TextArea] public string effectText;
        
        // text displayed on the naration when the card is chosed
        [TextArea] public string narrationText;
    }
}