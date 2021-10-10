using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Création d'effets sonores en toute simplicité
/// </summary>
public class SoundEffectHelper : MonoBehaviour
{

    /// <summary>
    /// Singleton
    /// </summary>
    public static SoundEffectHelper instance;

    public List<AudioClip> cutSounds;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Multiple instances of SoundEffectsHelper!");
        }
        instance = this;
    }

    public void MakeCutingSound()
    {
        MakeSound(cutSounds[Random.Range(0, cutSounds.Count)]);
    }

    /// <summary>
    /// Lance la lecture d'un son
    /// </summary>
    /// <param name="originalClip"></param>
    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}