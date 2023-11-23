using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPause : MonoBehaviour
{
    public AudioSource MusicPlayer;

    private void OnTriggerEnter(Collider other)
    {
        MusicPlayer.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        MusicPlayer.Stop();
    }
}
