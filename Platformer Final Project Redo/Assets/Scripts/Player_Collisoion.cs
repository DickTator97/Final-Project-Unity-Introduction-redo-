using UnityEngine;
public class Player_Collisoion : MonoBehaviour
{
    public Player_Movement movement;
    private void OnCollisionEnter(Collision CollisionInfo)
    {
        if (CollisionInfo.collider.CompareTag("Obstacle"))
        {

          movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}