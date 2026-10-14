using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int valor = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GerenciadorDoJogo.instancia.AdicionarPontos(valor);
            Destroy(gameObject);
        }

        
    }
}
