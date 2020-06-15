using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CharacterControlsJaune : MonoBehaviour
{
    public float speed = 1500f;
    public float jumpStrength = 500.0f;
    //public float gravity = -12.0f;
    //public CharacterController controller;
    public Transform cameraTransform;

    Vector3 moveAmount;
    Vector3 smoothMoveVelocity;


    public Transform groundCheck;
    public float groundDistance = 2.5f;
    public LayerMask groundMask;

    //VR management
    public SteamVR_Action_Vector2 moveAction;
    public SteamVR_Action_Single jumpAction;
    public SteamVR_Input_Sources handType;

    private Vector3 moveDir;

    float yVelocity = 0f;

    void Start() {
    }
    void Update(){
        // Move X and Z (determine movement)
        Vector2 dlVR =  moveAction.GetAxis(handType);
        Vector2 dlKeyboard =  new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 dl = dlVR + dlKeyboard;


        moveDir = cameraTransform.right * dl.x + cameraTransform.forward * dl.y;
        Vector3 targetMoveAmount = moveDir * speed;
        moveAmount = Vector3.SmoothDamp(moveAmount,targetMoveAmount,ref smoothMoveVelocity,.15f);
        moveDir.y = 0f;
        
        // Jump
        bool isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            float jumpIntensity = 0f;
            if (isGrounded){
                Debug.Log("ICI je dois sauter");
                yVelocity = -2f;
                jumpIntensity = Mathf.Pow(jumpAction.GetAxis(handType), 0.02f) + Input.GetAxis("Jump");
                yVelocity += Time.deltaTime + jumpIntensity * jumpStrength;
                
                GetComponent<Rigidbody>().AddForce(transform.up * jumpStrength);
            }
            //controller.Move(Vector3.up * (yVelocity*Time.deltaTime));
        
    }

    void FixedUpdate() {
        //Apply Movement to rigidbody
        Vector3 localMove = transform.TransformDirection(moveAmount) * Time.fixedDeltaTime;
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + localMove);
    }
}