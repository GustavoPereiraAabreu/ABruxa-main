using UnityEngine;
using UnityEngine.SceneManagement;

public class QUIT : MonoBehaviour
{
    public void Quit()
    {

        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}
