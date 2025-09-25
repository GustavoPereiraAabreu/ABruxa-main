using UnityEngine;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
 
    public void StartGame()
    {
      
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
}