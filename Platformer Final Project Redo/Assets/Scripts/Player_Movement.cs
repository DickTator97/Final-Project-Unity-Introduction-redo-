using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public Rigidbody rb;
    public float ForwardForce = 1650f;
    public float SidwaysForce = 165f;
    private void FixedUpdate()
    {
        // Add A forward force 
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            //Move Right
            rb.AddForce(SidwaysForce * Time.deltaTime, 0, 0);

            Debug.Log("Is Moving Right");

        }

        if (Input.GetKey("a"))
        {
            //Move Left
            rb.AddForce(-SidwaysForce * Time.deltaTime, 0, 0);

            Debug.Log("Is Moving Left");

        }
    }
}
