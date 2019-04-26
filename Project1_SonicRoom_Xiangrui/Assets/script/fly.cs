﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public Transform head;
   
    public SteamVR_TrackedObject leftHand;
    public SteamVR_TrackedObject rightHand;
   
    private bool isFlying = false;

   
    private void Update()
{
        var lDevice = SteamVR_Controller.Input((int)leftHand.index);
        var rDevice = SteamVR_Controller.Input((int)rightHand.index);
        if(lDevice.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger) || rDevice.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            isFlying = !isFlying;
        }

        if (isFlying)
        {
            Debug.Log("flying!!!!!!");
            Vector3 leftDir = leftHand.transform.position - head.position;
            Vector3 rightDir = rightHand.transform.position - head.position;
            Vector3 dir = leftDir + rightDir;
            transform.position += (dir * .05f);
            
        }
    }
}
