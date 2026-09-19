using UnityEngine;

public class enemigo1 : MonoBehaviour
{
    public float velocidadCaida = 3f;

    void Update()
    {
        transform.Translate(Vector2.down * velocidadCaida * Time.deltaTime);
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}

