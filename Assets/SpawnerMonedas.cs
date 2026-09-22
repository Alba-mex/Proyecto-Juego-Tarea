using UnityEngine;

public class SpawnerMonedas : MonoBehaviour
{
    public GameObject[] monedasPrefabs;
    public float tiempoEntreMonedas = 0.6f;
    public float minX = -8f;
    public float maxX = 8f;
    public float ySpawn = 6f;

    void Start()
    {
        InvokeRepeating("Spawnear", 1f, tiempoEntreMonedas);
    }

    void Spawnear()
    {
        if (monedasPrefabs.Length < 3) return;

        // 45% 10, 45% Negativa, 10% 30
        int suerte = Random.Range(0, 100);
        int indice = 0;

        if (suerte < 45) indice = 0; // Moneda10
        else if (suerte < 90) indice = 1; // MonedaNegativa - común
        else indice = 2; // Moneda30 - rara

        float x = Random.Range(minX, maxX);
        Vector3 pos = new Vector3(x, ySpawn, 0f);

        Instantiate(monedasPrefabs[indice], pos, Quaternion.identity);
    }
}