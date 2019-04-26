using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTrigger : MonoBehaviour
{
    public AudioSource SoundToPlay;

    void Awake()
    {
        SoundToPlay = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("yo!");
        SoundToPlay.Play();
    }


}
