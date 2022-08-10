using UnityEngine;
using UnityEngine.UIElements;
public class Player_Controller : MonoBehaviour
{
    //private int HP;
    //private int CoinCounter;

    float horizontal;
    float vertical;
    public float velocityMultiplier;
    public Rigidbody rb;

    Vector3 Velocity;
    public float RotationSpeed;
    bool IsJump;
    public float JumpForce;
    //AudioSource jumpsound;
    //public  GroundCheck m_GroundCheck;

    public Ground_Check M_GroundCheck;
  
    Vector3 RotateTowards;

    // ADD U.I To Coin Counter
    private void Start()
    {
        // player jumping sound
        rb = GetComponent<Rigidbody>();
        //jumpsound = GetComponent<AudioSource>();


    }
    private void Update()
    {
        // player movement
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        //jumping
        if (Input.GetButtonDown("Jump") && M_GroundCheck.IsGrounded == true)
        {
            IsJump = true;
            //jumpsound.Play();
            Debug.Log("Is Jumping");
        }
        
        // fix Jump to not work while in air

        if (horizontal != 0 || vertical != 0)
        {
            RotateTowards = new Vector3(rb.velocity.x, 0, rb.velocity.z);

            transform.forward = Vector3.MoveTowards(transform.forward, RotateTowards, Time.deltaTime * 50);
           
            Debug.Log("Is Moving");
        }

    }

    private void FixedUpdate()
    {


        // player jumping
        Velocity = new Vector3(horizontal * velocityMultiplier, rb.velocity.y, vertical * velocityMultiplier);
        
       
        if (IsJump)
        {
            Velocity.y += JumpForce;

            IsJump = false;

        }
        rb.velocity = Velocity;
      
      

    }

    // coin pickup


    //public void OnTriggerEnter(Collider other)
    //{
        //if (other.CompareTag("Coin"))
        //{

        //    // trigger picked coin animation
        //    other.GetComponent<Animator>().SetTrigger("CoinPicked");
        //    // play coin pickup SFX
        //    other.GetComponent<AudioSource>().Play();

        //    //Destroy Game Objectt(Coin)
        //    other.GetComponent<SphereCollider>().enabled = false;

        //    // increases the value of Coin Counter By One
        //    //if (CoinCounter >= 0)
        //    //{


        //    //    CoinCounter++;


        //    //}


        //}
        //Reapeat process with Mega Coin
        //else if (other.CompareTag("Mega Coin"))
        //{


        //    other.GetComponent<AudioSource>().Play();

        //    other.GetComponent<Animator>().SetTrigger("CoinPicked");

        //    other.GetComponent<SphereCollider>().enabled = false;

        //    //Reapets Process But Give an Additional Bonus To Coin Count
        //    //if (CoinCounter >= 0)
        //    //{


        //    //    CoinCounter += 100;


        //    //}
        //}

    //}

    // ADD U.I To Coin Counter
    // Add U.I To Player Hp
    //Add Taking Damage / Dying and respawning after fall from map

}