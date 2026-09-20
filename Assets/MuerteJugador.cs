using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteJugador : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}