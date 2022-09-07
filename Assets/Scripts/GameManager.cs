using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameStartCanvas;
    public GameObject gameplayCanvas;
    void Start()
    {
        Time.timeScale = 0;
        gameStartCanvas.SetActive(true);
        gameplayCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        gameStartCanvas.SetActive(false);
        gameplayCanvas.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
