using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public AudioClip gameOverSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager audioManager = FindObjectOfType<AudioManager>();
            if (audioManager != null)
            {
                audioManager.PlaySound(gameOverSound);
            }

            CoinCounter.coinCount = 0;  // Resetea el contador de monedas a 0

            // Reinicia la escena inmediatamente, el AudioManager seguirá reproduciendo el sonido.
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
