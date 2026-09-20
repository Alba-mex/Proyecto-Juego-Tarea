using UnityEngine;

public class Moverse : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 8f;
    private Rigidbody2D rb;
    private bool enSuelo;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movX = 0f;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) movX = -1f;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) movX = 1f;

        rb.linearVelocity = new Vector2(movX * velocidad, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Contains("Suelo") || col.gameObject.CompareTag("Suelo"))
            enSuelo = true;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        enSuelo = false;
    }
}