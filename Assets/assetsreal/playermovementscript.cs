using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementscript : MonoBehaviour
{   
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
       {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform. right * x +transform.forward *z;
        controller.Move(move * speed* Time.deltaTime);

       }
        //This is for gravity effects
        moveDirection.y -= gravity * Time.deltaTime;
        //For moving the controller
        controller.Move(moveDirection * Time.deltaTime);
    }
}
