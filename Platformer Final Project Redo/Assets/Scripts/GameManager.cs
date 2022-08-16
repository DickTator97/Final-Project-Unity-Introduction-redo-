using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool GameLost = false;
    public bool GameWon = false;
    public float RestartDelay = 1f;

    public GameObject LvlCompleteScreen;
    private void Start()
    {
       LvlCompleteScreen.SetActive(false); 
    }
    
    public void LevelComplete()
    {
        Debug.Log("You Win!");
        GameWon = true;
        LvlCompleteScreen.SetActive(true);
       

    }
    public void EndGame()
    {
        if (GameLost == false)
        {
            GameLost = true;
            Debug.Log("Game Over!");
            Invoke("RestartGame", RestartDelay);
        }
    }
   
    // Restarts The Level After The Game Is Lost(Can Be used For Win As well)
    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
