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

            // Reinicia la escena inmediatamente, el AudioManager seguir� reproduciendo el sonido.
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
