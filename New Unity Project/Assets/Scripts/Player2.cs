using System.Collections;
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
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (playerPosition < 1)
            {
                MovePaddleUp();
            }

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
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
