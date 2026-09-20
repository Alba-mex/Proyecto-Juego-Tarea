using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int monedas = 0;
    public TextMeshProUGUI textoMonedas;

    void Awake() { Instance = this; }

    public void SumarMoneda()
    {
        monedas++;
        if (textoMonedas != null)
            textoMonedas.text = "Monedas: " + monedas;
    }
}