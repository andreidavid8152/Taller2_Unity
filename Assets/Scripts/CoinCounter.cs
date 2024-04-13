using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Importa el espacio de nombres para TextMeshPro

public class CoinCounter : MonoBehaviour
{
    public static int coinCount = 0;  // Variable estática para mantener la cuenta de monedas
    public TextMeshProUGUI coinCountText;

    void Update()
    {
        coinCountText.text = "Coins: " + coinCount;  // Actualiza el texto del UI
    }

    public static void AddCoin()
    {
        coinCount++;  // Incrementa el contador de monedas
    }
}
