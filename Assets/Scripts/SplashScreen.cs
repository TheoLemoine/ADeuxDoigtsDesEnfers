using System.Collections;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float stayDuration = 2f;
    [SerializeField] private float fadeDuration = 2f;
    
    private IEnumerator Start()
    {
        spriteRenderer.enabled = true;

        yield return new WaitForSeconds(stayDuration);
        
        spriteRenderer.color = new Color(0, 0, 0, 1);

        for (float elapsed = 0f; elapsed < fadeDuration; elapsed += Time.deltaTime)
        {
            
            var progress = elapsed / fadeDuration;
            
            Debug.Log(progress);

            spriteRenderer.color = new Color(0, 0, 0, 1 - progress);

            yield return null;
        }
        
        spriteRenderer.color = new Color(0, 0, 0, 0);
    }
}