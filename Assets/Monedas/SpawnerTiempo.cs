using UnityEngine;

public class SpawnerTiempo : MonoBehaviour
{
    public GameObject prefabMoneda;
    public float tiempoEntreApariciones = 10f;

    public float rangoMinX = -7f;
    public float rangoMaxX = 7f;

    private float cronometro = 0f;

    void Update()
    {
        cronometro += Time.deltaTime;

        if (cronometro >= tiempoEntreApariciones)
        {
            GenerarMoneda();
            cronometro = 0f;
        }
    }

    void GenerarMoneda()
    {
        if (prefabMoneda != null)
        {
            float xAleatorio = Random.Range(rangoMinX, rangoMaxX);

            Vector3 posicionAleatoria = new Vector3(xAleatorio, transform.position.y, 0f);

            Instantiate(prefabMoneda, posicionAleatoria, Quaternion.identity);
        }
    }
}