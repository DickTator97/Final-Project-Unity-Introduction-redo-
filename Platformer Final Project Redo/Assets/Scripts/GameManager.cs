using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool GameLost = false;
    public bool GameWon = false;
    public float RestartDelay = 1f;
    public static bool IsPaused;
    public GameObject LVLCompScreen;
    public GameObject PauseMenu;
    //public MainMenu pauseMenu; 
    private void Start()
    {
        LVLCompScreen.SetActive(false);

        
    }
    private void OnEnable()
    {
        ContinueGame();

    }
    public void Update()
    {

        PauseScreen();

    }

    public void LevelComplete()
    {
        Debug.Log("You Win!");
        GameWon = true;
        LVLCompScreen.SetActive(true);
        PauseMenu.SetActive(false);
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

    // Restarts The Level 
    public void RestartGame()
    {
        Debug.Log("Is Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ContinueGame();
    }

    public void PauseScreen()
    {

        if (GameWon==false)
        {

            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
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
                PauseMenu.SetActive(true);

            }
            else
            {
                PauseMenu.SetActive(false);
            }
        } 
            
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        IsPaused = false;

    }


    public void LoadMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


    }
    public void IsBack()
    {
        if (gameObject == true)
        {
            PauseMenu.SetActive(false);
            Debug.Log(" Pause Menu Is now False");
        }
    }

}

