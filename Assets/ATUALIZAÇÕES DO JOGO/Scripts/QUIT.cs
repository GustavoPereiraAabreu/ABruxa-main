using UnityEngine;
using UnityEngine.SceneManagement;

public class QUIT : MonoBehaviour
{
    public void Quit()
    {

        SceneManager.LoadScene("Melissa (Tela Inicialr");
        Time.timeScale = 1f;
    }
}
