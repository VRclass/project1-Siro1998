using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTrigger : MonoBehaviour
{
    public AudioSource SoundToPlay;

    void Start()
    {
        SoundToPlay = GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        SoundToPlay.Play ();
    }
}
