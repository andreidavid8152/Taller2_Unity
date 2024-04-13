using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinSound;
    private GameObject audioManager;

    void Start()
    {
        audioManager = GameObject.FindWithTag("AudioManager");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Llama al m�todo PlaySound del AudioManager y pasa el coinSound
            audioManager.GetComponent<AudioManager>().PlaySound(coinSound);
            other.GetComponent<IncreaseSize>().IncreaseScale();  // Llama al m�todo para aumentar el tama�o

            CoinCounter.AddCoin();  // Incrementa el contador de monedas
            Destroy(gameObject); // Destruye la moneda inmediatamente
        }
    }
}
