using UnityEngine;

public class Altar : MonoBehaviour
{
    private bool podeInteragir = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            podeInteragir = true;
            MensagemUi.instance.MostrarMensagem("Pressione [E] no altar para invocar o inverno.");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            podeInteragir = false;
        }
    }

    void Update()
    {
        if (podeInteragir && Input.GetKeyDown(KeyCode.E))
        {
            if (ItensMenager.instance.TodosItensPegos())
            {
                MensagemUi.instance.MostrarMensagem("✨ A bruxa coloca os itens no altar... O inverno retorna! ❄️");
                // Aqui você pode chamar animações, trocar cenário, ativar neve, etc
            }
            else
            {
                MensagemUi.instance.MostrarMensagem("Ainda faltam itens mágicos para o ritual.");
            }
        }
    }
}
