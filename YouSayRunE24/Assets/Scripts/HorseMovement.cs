using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HorseMovement : MonoBehaviour
{
    //the animator on the horse. 
    Animator horseAnimator;
    // bools under the animator:
    bool isHWalking = false;
    bool isHRunning = false;
    bool isHIdle = true;
    bool isHJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    void DetectWASD_HMovementInput()
    {
        // If detecting movement inputs from the WASD keys, 
        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);



        if (isMoving == true)
        {
            isHIdle = false;
            isHIdle = false;

            isHWalking = !Input.GetKey(KeyCode.LeftShift);
            isHRunning = Input.GetKey(KeyCode.LeftShift);

        }
        else
        {
            isHIdle = true;
            isHWalking = false;
            isHRunning = false;
        }
    }
        // Update is called once per frame
            void Update()
            {
        
            }
}
