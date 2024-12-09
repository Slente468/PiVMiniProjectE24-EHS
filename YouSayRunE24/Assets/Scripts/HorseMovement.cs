using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/// <summary>
/// Now, for the mounting part, the plan is player goes up to horse w. collision on it to then press E, then player will snap
/// to MountPoint, and deactivate it's script and this script will be enabled instead. 
/// </summary>

// this line adds components  onto whatever the script is on.
[RequireComponent(typeof(Rigidbody))]//Note: this line of code must be on top of the inheritence public class from mono behavior, to work. 
public class HorseMovement : MonoBehaviour
{ // This one is basically a copy of PM just for horse. 
    // Movement inputs is raw
    private float x_input;
    private float z_input;
    //Reminder: AmericanZ, Horizontal/Vertical AD/WS, transform.forward = z

    //makes space for the 3 values vector moveDirection; is currently empty.
    Vector3 moveDirection;

    // reference to Rigidbody for movement
    Rigidbody rb;
    //Reminder: this be empty; it needs to be filled with the component in question.

    //Variable, This is defualt walkingSpeed, for method and animation.
    [SerializeField] private float walkingSpeed = 7f;
    [SerializeField] private float jumpPower = 8f;
    [SerializeField] private float runningSpeed = 15f;

    // Animator reference
    [SerializeField] private Animator HorseAnimator;

    //Mount stuff
    [SerializeField] private GameObject Micah;  
    [SerializeField] private GameObject horsetop;
    [SerializeField] private GameObject MountPoint;

    //[SerializeField] private MonoBehaviour PMS; 
    //[SerializeField] private MonoBehaviour HorseMovementS;

    public bool isTorstarted = false;

    private bool isMounted = false;             

    // Start is called before the first frame update
    void Start()
    {
        // Initialize Rigidbody and Animator components
        rb = GetComponent<Rigidbody>();

        
        
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
        HorseRotationAndAnimations();

        //jump method
        HorseInputJump();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Settings");
            isTorstarted = true;

        }

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

   
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E)) 
        {
            MountHorse();
        }
    }

    private void MountHorse()
    {
        if (isMounted)
        {
            return; 
        }//Stops from mounting if already mounted

        // Snap the player to the horsetop position and rotation
        Micah.transform.position = MountPoint.transform.position;
        Micah.transform.rotation = MountPoint.transform.rotation;
        //MountPoint is an empty child on top of horsetop

        // Parent the player to the horsetop
        Micah.transform.SetParent(horsetop.transform);

        // Disable the player's movement script and enable the horse movement script
        //PMS.enabled = false;

        

        isMounted = true;  // Update the mounted status
    }


    // Handle rotation and animations
    private void HorseRotationAndAnimations()
    {
        if (moveDirection != Vector3.zero)
        {
            HorseAnimator.SetBool("isHIdle", false);
            // Rotate to face the movement direction
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10f * Time.deltaTime);

            // Play walking animation
            HorseAnimator.SetBool("isHWalking", true);
        }
        else if (moveDirection != Vector3.zero && Input.GetKeyDown(KeyCode.LeftShift))
        {
            HorseAnimator.SetBool("isHIdle", false);
            HorseAnimator.SetBool("isHRunning", true);
        }
        else
        {
            // Play idle animation
            HorseAnimator.SetBool("isHWalking", false);
            HorseAnimator.SetBool("isHRunning", false);
            HorseAnimator.SetBool("isHIdle", true);
            //taking no chances
        }
    }
    void HorseInputJump()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce.up = jump;
            //rb.AddForce(new Vector3(rb.velocity.x, rb.velocity.y*jumpPower,rb.velocity.z));
            rb.AddForce(new Vector3(rb.velocity.x, jumpPower, rb.velocity.z), ForceMode.Impulse);
            Debug.Log("we jumped.");
            HorseAnimator.SetBool("isHJumping", true);


        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            HorseAnimator.SetBool("isHJumping", false);
        }



    }
}
