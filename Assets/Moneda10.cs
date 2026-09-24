using UnityEngine;

public class Moneda10 : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.ModificarPuntos(10);
            }
            Destroy(gameObject);
        }
    }
}