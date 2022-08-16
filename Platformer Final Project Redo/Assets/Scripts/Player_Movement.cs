using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForceForward;
    public float ForceSideWays;
    public GameManager manager;


    public void Start()
    {

        if (ForceForward > 0)
        {
            Debug.Log("Forward Force is equal to:" + ForceForward);
        }

    }
    private void FixedUpdate()
    {
        if (manager.GameWon)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            return;
        }
        // Add A forward force 
        rb.AddForce(0, 0, ForceForward * Time.deltaTime);

        //Steer Right
        if (Input.GetKey("d"))
        {
            rb.AddForce(ForceSideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            Debug.Log("is Steering Right");


        }
        //Steer Left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-ForceSideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            Debug.Log("is Steering Left");

        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        // ADD Jumping
        // Making Sure Player Can Only Jump Once And Not Jump Again While Airborne
    }
}
