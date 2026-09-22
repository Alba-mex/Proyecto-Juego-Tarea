using UnityEngine;

public class Moneda30 : MonoBehaviour
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
                GameManager.Instance.ModificarPuntos(30);
            }
            Destroy(gameObject);
        }
    }
}