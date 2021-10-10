using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScriptableObjects.Cards
{
    
    [CreateAssetMenu(fileName = "ReplayCard", menuName = "Scriptable/Card/ReplayCard", order = 0)]
    public class ReplayCard : ACard
    {
        public override bool CanGoThrough() => true;

        public override void RunEffect()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}