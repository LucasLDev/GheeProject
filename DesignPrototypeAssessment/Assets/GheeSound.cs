using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GheeSound : MonoBehaviour
{
    private AudioSource audSrc;
    public AudioClip[] audioClipArray;

     GheeSpawn _ghee;

    void Start()
    {
        // on startup, get a reference to the audio source on this game object
        audSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_ghee.pickedUp == true)
        {
            PlayRandomlySelectedSound();
        }
    }


    void PlayRandomlySelectedSound()
    {
        //plays a randomly selected sound from an array
        audSrc.PlayOneShot(audioClipArray[Random.Range(0, audioClipArray.Length)]);
    }


}
