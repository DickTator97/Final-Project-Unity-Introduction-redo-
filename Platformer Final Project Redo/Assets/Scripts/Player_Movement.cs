using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForceForward;
    public float ForceSideWays;
    public GameManager manager;
    private void Start()
    {

        if (ForceForward > 0)
        {
            Debug.Log("Fwrd Force =:" + ForceForward);
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
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(ForceSideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            Debug.Log("is Steering Right");
        }
        //Steer Left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-ForceSideWays * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

            Debug.Log("is Steering Left");

        }
        if (rb.position.y < -1f)
        {
            Debug.Log("Is Falling : GAME OVER!");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
