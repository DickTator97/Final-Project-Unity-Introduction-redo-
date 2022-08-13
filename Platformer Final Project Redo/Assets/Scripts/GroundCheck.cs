using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//new project Script
public class GroundCheck : MonoBehaviour
{
    public bool IsGrounded;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            IsGrounded = true;
            Debug.Log("Is Jumping");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            IsGrounded = false;
            Debug.Log("Is Not Jumping");
        }
    }
}
