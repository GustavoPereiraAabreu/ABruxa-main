using UnityEngine;
using UnityEngine.SceneManagement;

public class QUIT : MonoBehaviour
{
    public void Quit()
    {

        SceneManager.LoadScene("Melissa Iniciar");
        Time.timeScale = 1f;
    }
}
