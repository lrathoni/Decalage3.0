﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CharacterControls : MonoBehaviour
{
    public float speed = 25.0f;
    public CharacterController controller;
    public Transform cameraTransform;

    public SteamVR_Action_Vector2 moveAction;
    public SteamVR_Input_Sources handType;

    void Update(){
        Vector2 dl = speed * Time.deltaTime * moveAction.GetAxis(handType);
        Vector3 move = cameraTransform.right * dl.x + cameraTransform.forward * dl.y;
        move.y = 0;
        controller.Move(move);
    }
}