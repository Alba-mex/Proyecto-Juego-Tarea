using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float tiempoEntreSpawn = 1.5f;
    public float velocidadMin = 2f;
    public float velocidadMax = 5f;

    void Start()
    {
        InvokeRepeating("Spawnear", 1f, tiempoEntreSpawn);
    }

    void Spawnear()
    {
        float xRandom = Random.Range(-8f, 8f);
        Vector2 pos = new Vector2(xRandom, transform.position.y);
        GameObject nuevo = Instantiate(enemigoPrefab, pos, Quaternion.identity);
        nuevo.GetComponent<enemigo1>().velocidadCaida = Random.Range(velocidadMin, velocidadMax);
    }
}
