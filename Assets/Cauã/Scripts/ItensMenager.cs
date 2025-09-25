using UnityEngine;

public class ItensMenager : MonoBehaviour
{
    public static ItensMenager instance;

    public int itensColetados = 0;
    public int totalItens = 3;

    void Awake()
    {
        instance = this;
    }

    public void PegarItem()
    {
        itensColetados++;
        MensagemUI.instance.MostrarMensagem("Itens coletados: " + itensColetados);
    }

    public bool TodosItensPegos()
    {
        return itensColetados >= totalItens;
    }
}
