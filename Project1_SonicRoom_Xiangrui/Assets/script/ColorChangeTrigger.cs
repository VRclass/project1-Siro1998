using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeTrigger : MonoBehaviour
{
    public Color whitecolor;
    public bool enter = true;

    void OnTriggerEnter(Collision other)
    {
        transform.GetComponent<Renderer>().material.color = whitecolor;
        if (enter)
        {
            Debug.Log("entered");
        }
    }
}