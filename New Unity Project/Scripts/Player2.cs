﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Rigidbody rb;
    private int playerPosition = 0;
    public float MoveDistance = 1;




    private void FixedUpdate()
    {
        CheckForPlayerInput();
    }

    // Players Input Controls
    public void CheckForPlayerInput()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (playerPosition < 3)
            {
                MovePaddleUp();
            }

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (playerPosition > -3)
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
