using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo; // Referência ao objeto que a camera vai seguir
    public Vector3 deslocamento = new Vector3(0f, 5f, -10f);
    public float suavizacao = 5f; // Quando mais baixo, mais suave será o movimento da câmera
    private void LateUpdate()
    {
        Vector3 posicaoDesejada = alvo.position + deslocamento;
        transform.position = Vector3.Lerp(transform.position, posicaoDesejada, suavizacao * Time.deltaTime);
        transform.LookAt(alvo); // Faz a camera olhar para o alvo
    }
    
}
