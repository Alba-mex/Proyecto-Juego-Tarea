using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int puntos = 0;
    public TextMeshProUGUI textoMonedas;

    void Awake()
    {
        Instance = this;
    }
    public void ModificarPuntos(int cantidad)
    {
        puntos += cantidad;

        if (textoMonedas != null)
        {
            textoMonedas.text = "Puntos: " + puntos;
        }
    }
}