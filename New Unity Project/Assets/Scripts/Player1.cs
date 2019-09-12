﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Rigidbody rb;
    private int playerPosition = 0;
    public float MoveDistance = 5;


    

    private void FixedUpdate()
    {
        CheckForPlayerInput();
    }

    // Players Input Controls
    public void CheckForPlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (playerPosition < 1)
            {
                MovePaddleUp();
            }
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (playerPosition > -1)
            {
                MovePaddleDown();
            }
            
        }

    }

    //Input actions
    public void MovePaddleUp()
    {
        rb.transform.Translate(0, 0, MoveDistance);
        playerPosition++;
    }

    public void MovePaddleDown()
    {
        rb.transform.Translate(0, 0, -MoveDistance);
        playerPosition--;
    }
}