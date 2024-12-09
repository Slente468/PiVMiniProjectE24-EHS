using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;


//this script includes the player's movement controls and the CameraThatFollows(notmadeYet) configurations & How the player interact with the world.
//hold: 
// movement of player | complete 1t 46 min. 
// jump of player
// run of player 


// this line adds components  onto whatever the script is on.
[RequireComponent(typeof(Rigidbody))]//Note: this line of code must be on top of the inheritence public class from mono behavior, to work. 
public class PlayerManager : MonoBehaviour
{
    // variables for holding the x and z values, gets them in Update(), whether the player moves or not, used to calculate moveDirection in the PMovement().
    float x_input;
    float z_input;



    //makes space for the 3 values vector moveDirection; is currently empty.
    Vector3 moveDirection;

    Rigidbody rb;
    //Reminder: this be empty; it needs to be filled with the component in question.

    //Variable, This is defualt walkingSpeed, for method and animation.
    [SerializeField] private float walkingSpeed = 7f;
    [SerializeField] private float jumpPower = 8f;
    [SerializeField] private float runningSpeed = 15f;


    //the animator on the player. 
    Animator playerAnimator;
    // bools under the animator:
    bool isPWalking = false; 
    bool isPRunning = false; 
    bool isPIdle = true; 
    bool isPJumping = false; 
    bool isPSitUp = false;
    // Trigger TheSitUp
    //


    // Start is called before the first frame update
    void Start()
    {
        //used in methods for movement. 
        playerAnimator = GetComponent<Animator>();

        
        rb = GetComponent<Rigidbody>();


        
    }

    //PMovement, method for getting axis data of x and z and declaring the movedirecton vector. 
    //Does not need to return anything by itself, therefore void.
    //This Mehod is called in Update, to get the axis inputs every frame. 
   void PMovementDirections()
    {
        x_input = Input.GetAxisRaw("Horizontal");
        z_input = Input.GetAxisRaw("Vertical");
        //Reminder: AmericanZ, Horizontal/Vertical AD/WS, transform.forward = z

        // the normalized make the diagonal movment to 1 instead of the 1.4 ish. it was on at defualt when combining x and z inputs.
        moveDirection = new Vector3(x_input, 0f, z_input).normalized;
        // this is a Vector3, though it could be a Vector2, but is not because I tried that first and managed to get it working with x and y inputs instead of x and z. So, it's more for my sake, for visualizing what's happening, that is we are not getting y, so y = 0f in this case..

        //x_inputMouse = Input.GetAxisRaw("Mouse X");
        //z_inputMouse = Input.GetAxisRaw("Mouse Y");


        //if (moveDirection != Vector3.zero)

    } //should rotate  face in movement direction





    void Walking()
    {
        rb.velocity = new Vector3(moveDirection.x * walkingSpeed, rb.velocity.y, moveDirection.z * walkingSpeed);
        //the y is set to rb.velocity because, if 0f, it will in fixed update set itself to 0f, which is a problem when we are trying to get PlayerInputJump to work in Update.
        playerAnimator.SetBool("isPWalking", true);



    }

    void Running()
    {
        rb.velocity = new Vector3(moveDirection.x * runningSpeed, rb.velocity.y, moveDirection.z * runningSpeed);
        //the y is set to rb.velocity because, if 0f, it will in fixed update set itself to 0f, which is a problem when we are trying to get PlayerInputJump to work in Update.

    }

    void PlayerMov()
    {
        //Walk to run toggle, if held down.
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Running();
            
        }
        else 
        {
            Walking();
            
            

        }
    }


    void PlayerInputJump()
    {
        

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            //float jump = rb.AddForce.up;
            //rb.AddForce(new Vector3(rb.velocity.x, rb.velocity.y*jumpPower,rb.velocity.z));
            rb.AddForce(new Vector3(rb.velocity.x, jumpPower, rb.velocity.z), ForceMode.Impulse);
            Debug.Log("we jumped.");
            playerAnimator.SetBool("isPJumping", true);
             

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("isPJumping", false);
        }
      


    }

    //-----------------------------------------------
    //This part of the script deals with the animations on the player character basically just methods with bools checking whether interaction with keyboard = 
    //Reminder: Up
    void DetectWASDMovementInput()
    {
        // If detecting movement inputs from the WASD keys, 
        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);



        if (isMoving == true)
        {
            isPIdle = false;
            

            isPWalking = !Input.GetKey(KeyCode.LeftShift);
            isPRunning = Input.GetKey(KeyCode.LeftShift);

        }
        else
        {
            isPIdle = true;
            isPWalking = false;
            isPRunning = false;
        }

        // Updates the player animator parameters
        playerAnimator.SetBool("isPWalking", isPWalking);
        playerAnimator.SetBool("isPRunning", isPRunning);
        playerAnimator.SetBool("isPIdle", isPIdle);
    }

    void DetectsJumpInput()
    {
        // Detect jump input (Space key)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPJumping = true;
            playerAnimator.SetBool("isPJumping", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            isPJumping = false;
            playerAnimator.SetBool("isPJumping", false);
        }
    }



// Update is called once per frame
void Update()
    {
        PMovementDirections();
        PlayerInputJump();
        PlayerMov();

        //for the animate controller
        DetectWASDMovementInput();
        DetectsJumpInput();

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Horse"))
            {    isPSitUp = true;
                // Trigger the SitUp animation
                playerAnimator.SetTrigger("TheSitUp");
                
            }
        }

    }

     void FixedUpdate()
    {
        



    }

}

 