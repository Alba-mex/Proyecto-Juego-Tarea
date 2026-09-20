using UnityEngine;

public class SpawnerMonedas : MonoBehaviour
{
    public GameObject moneda10Prefab;
    public float tiempoEntreMonedas = 2f;

    public float minX = -8f;
    public float maxX = 8f;
    public float minY = -3f;
    public float maxY = 3f;

    void Start()
    {
        InvokeRepeating("SpawnearMoneda", 1f, tiempoEntreMonedas);
    }

    void SpawnearMoneda()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        Vector2 posicion = new Vector2(x, y);
        Instantiate(moneda10Prefab, posicion, Quaternion.identity);
    }
}