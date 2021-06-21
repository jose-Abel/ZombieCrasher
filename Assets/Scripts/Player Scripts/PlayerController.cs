using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private Rigidbody myBody;

    void Start()
    {
        myBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ControlMovementWithKeyboard();
    }

    void FixedUpdate() {
        MoveTank();
    }

    void MoveTank() {
        myBody.MovePosition(myBody.position + speed * Time.deltaTime);
    }

    void ControlMovementWithKeyboard() {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {

            MoveLeft();
        }

        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            
            MoveRight();
        }

        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            
            MoveFast();
        }

        if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
            
            MoveSlow();
        }

        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A)) {
            
            MoveStraight();
        }

        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            
            MoveStraight();
        }

        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            
            MoveNormal();
        }

       if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
            
            MoveNormal();
        }
    }
}
