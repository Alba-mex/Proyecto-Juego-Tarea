using UnityEngine;

public class MonedaNegativa : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 8f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.ModificarPuntos(-20);
            }
            Destroy(gameObject);
        }
    }
}