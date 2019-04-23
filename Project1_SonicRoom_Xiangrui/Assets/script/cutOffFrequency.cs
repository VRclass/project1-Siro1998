using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(AudioHighPassFilter))]

public class cutOffFrequency : MonoBehaviour
{

    AudioSource audioData;

    public Transform rightController;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioHighPassFilter>().cutoffFrequency = rightController.position.y * 100;
    }
}