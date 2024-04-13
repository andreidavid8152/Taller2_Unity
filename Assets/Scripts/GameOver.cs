using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public AudioClip gameOverSound;

    void Update()
    {
        if (transform.position.y < -5)
        {
            GameEnd();
        }
    }

    void GameEnd()
    {
        // Reproduce el sonido de Game Over.
        AudioManager audioManager = FindObjectOfType<AudioManager>();
        if (audioManager != null && gameOverSound != null)
        {
            audioManager.PlaySound(gameOverSound);
        }

        CoinCounter.coinCount = 0;  // Resetea el contador de monedas a 0

        // Reinicia inmediatamente la escena.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
