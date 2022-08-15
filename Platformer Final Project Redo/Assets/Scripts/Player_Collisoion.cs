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
            FindObjectOfType<GameManager>().EndGame();
        }
        //// Set Level Win If Hitting FinishLine
        //if (CollisionInfo.collider.CompareTag("FinishLine"))
        //{
        //    FindObjectOfType<GameManager>().LevelComplete();
        //}


    }

}