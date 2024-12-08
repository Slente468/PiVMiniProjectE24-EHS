using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycastings : MonoBehaviour
{
    //These used in PlayerInputJump to turn off&on the the jump abillity using raycasting. 
   public bool isGrounded;
    float maxDistRayCastingGround = 0.2f;
    public LayerMask groundMask;

    // Start is called before the first frame update
    void Start()
    {
        groundMask = LayerMask.GetMask("groundMask");
    }

    public bool IsPlayerGrounded()
    {

        // position(on gameobject), direction of y(down), the distance of the raycast(else infinity), and layermask(the one we are checking on hitting.)


        isGrounded = Physics.Raycast(transform.position, -transform.up, maxDistRayCastingGround, groundMask);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, maxDistRayCastingGround, groundMask))
        {
            Debug.Log($"Grounded on: {hit.collider.gameObject.name}");
            return true;
        }
        Debug.Log("Not grounded.");
        return false;



    }



        

        // Update is called once per frame
        void Update()
    {
        IsPlayerGrounded();
        Debug.DrawRay(transform.position, -transform.up, Color.yellow, maxDistRayCastingGround);
        Debug.Log(IsPlayerGrounded());
    }
}
