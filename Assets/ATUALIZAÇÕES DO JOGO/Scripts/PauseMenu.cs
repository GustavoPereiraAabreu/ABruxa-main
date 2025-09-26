using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    private bool isPaused = false;

    void Start()
    {
        if (pauseUI != null)
            pauseUI.SetActive(false); 
        Time.timeScale = 1.0f;
    }

    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        if (pauseUI != null)
            pauseUI.SetActive(true);

        Time.timeScale = 0f; 
        isPaused = true;
    }

    public void ResumeGame()
    {
        if (pauseUI != null)
            pauseUI.SetActive(false);

        Time.timeScale = 1f;
        isPaused = false;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Melissa (Tela Inicial)");
        Time.timeScale = 1f;
    }
}