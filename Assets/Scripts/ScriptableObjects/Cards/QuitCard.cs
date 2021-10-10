using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScriptableObjects.Cards
{
    
    [CreateAssetMenu(fileName = "QuitCard", menuName = "Scriptable/Card/QuitCard", order = 0)]
    public class QuitCard : ACard
    {
        public override bool CanGoThrough() => true;

        public override void RunEffect()
        {
            Application.Quit();
        }
    }
}