using UnityEngine;
using TMPro;

public class MensagemUi : MonoBehaviour
{
    public static MensagemUi instance; 
    public TextMeshProUGUI textoMensagem;
    public float tempoExibicao = 2f; 
    private float timer;

    void Awake()
    {
        instance = this;
        textoMensagem.text = "";
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                textoMensagem.text = "";
            }
        }
    }

    public void MostrarMensagem(string msg)
    {
        textoMensagem.text = msg;
        timer = tempoExibicao;
    }
}
