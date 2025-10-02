using UnityEngine;

public class InstantKillTrap : MonoBehaviour
{
    public GameObject gameOverUI;

    private void Start()
    {
        if (gameOverUI != null)
            gameOverUI.SetActive(false); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameOverUI != null)
            {
                gameOverUI.SetActive(true); 
                Time.timeScale = 0f;
            }

        }
    }
}