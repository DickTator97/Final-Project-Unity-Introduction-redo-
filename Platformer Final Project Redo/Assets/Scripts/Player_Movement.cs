using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForceForward;
   public float ForceSideWays;
    public bool IsJump;
    private void FixedUpdate()
    {
        // Add A forward force 
        rb.AddForce(0, 0, ForceForward * Time.deltaTime);

       
        if (Input.GetKey("d"))
        {
            //Move Right
            rb.AddForce(ForceSideWays * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

            Debug.Log("Is Moving Right");

        }

        if (Input.GetKey("a"))
        {
            //Move Left
            rb.AddForce(-ForceSideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            Debug.Log("Is Moving Left");

        }

        // ADD Jumping
        // Making Sure Player Can Only Jump Once And Not Jump Again While Airborne
    }
}


//private void Update()
//{
//    // player movement
//    horizontal = Input.GetAxis("Horizontal");
//    vertical = Input.GetAxis("Vertical");

//    //jumping
//    if (Input.GetButtonDown("Jump") && M_GroundCheck.IsGrounded == true)
//    {
//        IsJump = true;
//        //jumpsound.Play();
//        Debug.Log("Is Jumping");
//    }

//    // fix Jump to not work while in air

//    if (horizontal != 0 || vertical != 0)
//    {
//        RotateTowards = new Vector3(rb.velocity.x, 0, rb.velocity.z);

//        transform.forward = Vector3.MoveTowards(transform.forward, RotateTowards, Time.deltaTime * 50);

//        Debug.Log("Is Moving");
//    }

//}
// // player jumping
//Velocity = new Vector3(horizontal * velocityMultiplier, rb.velocity.y, vertical * velocityMultiplier);

//if (IsJump)
//{
//    Velocity.y += JumpForce;

//    IsJump = false;

//}
//rb.velocity = Velocity;