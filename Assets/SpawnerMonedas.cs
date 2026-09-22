using UnityEngine;

public class SpawnerMonedas : MonoBehaviour
{
    public GameObject[] monedasPrefabs; // 0=10, 1=Negativa -20, 2=30 rara
    public float tiempoEntreMonedas = 0.6f;
    public float minX = -8f;
    public float maxX = 8f;
    public float minY = -3f;
    public float maxY = 3f;

    void Start()
    {
        InvokeRepeating("SpawnearMoneda", 0.5f, tiempoEntreMonedas);
    }

    void SpawnearMoneda()
    {
        if (monedasPrefabs.Length < 3) return;

        int indice = 0;
        int suerte = Random.Range(0, 100);

        if (suerte < 45)
        {
            indice = 0; // Moneda 10 -> 45%
        }
        else if (suerte < 90)
        {
            indice = 1; // Moneda Negativa -20 -> 45%
        }
        else
        {
            indice = 2; // Moneda 30 -> 10% muy rara
        }

        GameObject monedaElegida = monedasPrefabs[indice];
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        Vector2 posicion = new Vector2(x, y);

        Instantiate(monedaElegida, posicion, Quaternion.identity);
    }
}