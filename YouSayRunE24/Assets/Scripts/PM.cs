using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//so something in my old script stopped working, so did it a second time, because time and this works 
// this line adds components  onto whatever the script is on.
[RequireComponent(typeof(Rigidbody))]//Note: this line of code must be on top of the inheritence public class from mono behavior, to work. 
public class PM : MonoBehaviour
{
    // Movement inputs is raw
    private float x_input;
    private float z_input;
    //Reminder: AmericanZ, Horizontal/Vertical AD/WS, transform.forward = z

    //makes space for the 3 values vector moveDirection; is currently empty.
    Vector3 moveDirection;

    // Reference to Rigidbody for movement
    Rigidbody rb;
    //Reminder: this be empty; it needs to be filled with the component in question.

    //Variable, This is defualt walkingSpeed, for method and animation.
    [SerializeField] private float walkingSpeed = 7f;
    [SerializeField] private float jumpPower = 8f;
    [SerializeField] private float runningSpeed = 15f;

    // Animator reference
    [SerializeField] private Animator playerAnimator;

    /// <summary>
    /// the horse mounting happens in HorseMovement Script. Go there, to do the mounting press E. 
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        // Initialize Rigidbody and Animator components
        rb = GetComponent<Rigidbody>();
        //playerAnimator = GetComponent<Animator>();
    }

   

    // Update is called once per frame
    void Update()
    {
        // Get player input and determine move direction
        x_input = Input.GetAxisRaw("Horizontal");
        z_input = Input.GetAxisRaw("Vertical");

        // Normalize the movement direction
        moveDirection = new Vector3(x_input, 0f, z_input).normalized;

        // Handles rotation and animations of player
        PlayerRotationAndAnimations();

        

        //jump method
        PlayerInputJump();

        // Move the player
        if (moveDirection != Vector3.zero)
        {
            rb.velocity = new Vector3(moveDirection.x * walkingSpeed, rb.velocity.y, moveDirection.z * walkingSpeed);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity = new Vector3(moveDirection.x * runningSpeed, rb.velocity.y, moveDirection.z * runningSpeed);
            }
        }
    }

    
    

    // Handle rotation and animations
    private void PlayerRotationAndAnimations()
    {
        if (moveDirection != Vector3.zero)
        {
            playerAnimator.SetBool("isPIdle", false);
            // Rotate to face the movement direction
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10f * Time.deltaTime);

            // Play walking animation
            playerAnimator.SetBool("isPWalking", true);
        }
        else
        {
            // Play idle animation
            playerAnimator.SetBool("isPWalking", false);
            playerAnimator.SetBool("isPIdle", true);
            //taking no chances
        }
    }
    void PlayerInputJump()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce.up = jump;
            //rb.AddForce(new Vector3(rb.velocity.x, rb.velocity.y*jumpPower,rb.velocity.z));
            rb.AddForce(new Vector3(rb.velocity.x, jumpPower, rb.velocity.z), ForceMode.Impulse);
            Debug.Log("we jumped.");
            playerAnimator.SetBool("isPJumping", true);


        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnimator.SetBool("isPJumping", false);
        }

        

}
}
