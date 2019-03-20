using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heightPitch : MonoBehaviour
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
        audioData.pitch = rightController.position.y;
    }
}
