using UnityEngine;
public class Player_Collisoion : MonoBehaviour
{
    public Player_Movement movement;
    private void OnCollisionEnter(Collision CollisionInfo)
    {
        //Set Level Failure\Reloading For Hitting An Obstacle

       
        if (CollisionInfo.collider.CompareTag("Obstacle"))
        {
           
            movement.enabled = false;
            Debug.Log("Is Crashing");
            
            //if ((movement.ForceForward == 0)&& (movement.ForceSideWays==0) )
            //{
            //    // position on y axis should stay the same while player on road
            //}
            FindObjectOfType<GameManager>().EndGame();

        }
        
    }

}