using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D Controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;


    // Update is called once per frame
    void Update()

    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

    }
    void FixedUpdate()
    {

        Controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);

    }
}