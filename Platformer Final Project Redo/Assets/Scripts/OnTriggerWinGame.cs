
using UnityEngine;

public class OnTriggerWinGame : MonoBehaviour
{

    public GameManager gamemanager;
    private void OnTriggerEnter(Collider other)
    {
        // Fix To Work Only When Player Collides With Finish Line's Collider
        if (other.tag == "Player")
        {
            gamemanager.LevelComplete();

        }

    }
 
}
