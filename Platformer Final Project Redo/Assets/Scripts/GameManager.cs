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
    public MainMenu PauseMenu;
    //public GameObject ContinueButton;
    private void Start()
    {
        LVLCompleteScreen.SetActive(false);
        PauseMenuCanvas.SetActive(false);
    }
    public void Update()
    {

        PauseScreen();


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
        ContinueGame();
    }

    public void PauseScreen()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!IsPaused)
            {
                Time.timeScale = 0;
                IsPaused = true;
            }
            else
            {
                ContinueGame();
            }

        }
        if (IsPaused)
        {
            PauseMenuCanvas.SetActive(true);

        }
        else
        {
            PauseMenuCanvas.SetActive(false);
        }

    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        IsPaused = false;

    }

    public void GoToOptions()
    {
        //
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Exit()
    {

        PauseMenu.QuitGame();
    }


}

