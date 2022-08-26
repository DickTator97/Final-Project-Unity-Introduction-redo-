using UnityEngine;
public class Player_Collisoion : MonoBehaviour
{
    public Player_Movement movement;
    private void OnCollisionEnter(Collision CollisionInfo)
    {
        //Set Level Failure\Reloading For Hitting An Obstacle

        // 1.Player Enter an obstacle 
        if (CollisionInfo.collider.CompareTag("Obstacle"))
        {
           
            //movement.enabled = false;
            Debug.Log("Is Crashing");
            //2. goes to "GameManager" Script
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }

}