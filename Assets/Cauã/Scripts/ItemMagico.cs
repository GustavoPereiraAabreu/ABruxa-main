using UnityEngine;

public class ItemMagico : MonoBehaviour
{
    private bool podeInteragir = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            podeInteragir = true;
            MensagemUi.instance.MostrarMensagem("Pressione [E] para coletar o item mágico!");
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
            ItensMenager.instance.PegarItem();
            MensagemUi.instance.MostrarMensagem("Você coletou um item mágico!");
            Destroy(gameObject); // remove o item
        }
    }
}

