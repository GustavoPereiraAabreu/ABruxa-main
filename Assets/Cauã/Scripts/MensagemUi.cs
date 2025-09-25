using UnityEngine;
using TMPro;

public class MensagemUI : MonoBehaviour
{
    public static MensagemUI instance; 
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
