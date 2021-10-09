using TMPro;
using UnityEngine;

public class Narration : MonoBehaviour
{
    private static Narration instance;

    public TextMeshPro narrationTMP;

    private void Start()
    {
        if (instance != null)
        {
            Debug.LogWarning("Can have more than one narration manager");
            Destroy(this);
        }
                
        instance = this;
    }

    public static void SetText(string text)
    {
        instance.narrationTMP.text = text;
    }
}