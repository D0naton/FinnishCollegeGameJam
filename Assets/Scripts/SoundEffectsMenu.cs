using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsMenu : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2;

    public void PlayButton ()
    {
        src.clip = sfx1;
        src.Play();
     
    }
    public void OptionsButton ()
    {
        src.clip = sfx2;
        src.Play();
    }
}
