using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool GameLost = false;
    public bool GameWon = false;
    public float RestartDelay = 1f;
    public static bool IsPaused;
    public GameObject LVLCompleteScreen;
    public GameObject PauseMenuCanvas;
   
    private void Start()
    {
        LVLCompleteScreen.SetActive(false);
          PauseMenuCanvas.SetActive(false);
    }
    public void Update()
    {

        // Unfinished
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!IsPaused)
            {
                Time.timeScale = 0;
                IsPaused = true;
            }
            else
            {
                Time.timeScale = 1;
                IsPaused = false;
            }
            
        }
         if (IsPaused)
        {
            PauseMenuCanvas.SetActive(true);

        } else
        {
            PauseMenuCanvas.SetActive(false);
        }

        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    while (PauseMenuCanvas==true)
        //    {
        //        PauseMenuCanvas.SetActive(false);
        //    }
        //}

    }


    public void LevelComplete()
    {
        Debug.Log("You Win!");
        GameWon = true;
        LVLCompleteScreen.SetActive(true);

    }
    public void EndGame()
    {
        if (GameLost == false)
        {
            GameLost = true;
            Debug.Log("Game Over!");
            // Add a Game Over Screen+ Restart Button+ Stop Player Movement
            Invoke("RestartGame", RestartDelay);

        }

    }

    // Restarts The Level After The Game Is Lost(Can Be used For Win As well)
    public void RestartGame()
    {
        Debug.Log("Is Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    

}
