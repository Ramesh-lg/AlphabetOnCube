using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnKeyPress : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] clip;

    private void Start()
    {
       // audioSource.PlayOneShot(clip[0]);

    }

    public void PlayAudioOnKey()
    {
        Debug.Log("Calling outside");
        audioSource.PlayOneShot(clip[0]);
    }
}
