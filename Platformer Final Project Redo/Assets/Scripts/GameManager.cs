using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool GameLost = false;
    public bool GameWon = false;
    public float RestartDelay = 1f;

    public GameObject CompleteLevlUI;
    public void LevelComplete()
    {
        Debug.Log("You Win!");
        CompleteLevlUI.SetActive(true);

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

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
