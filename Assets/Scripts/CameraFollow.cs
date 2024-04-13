using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // El objetivo que la cámara seguirá, asigna esto al cubo en el inspector
    public Vector3 offset;    // La distancia y dirección relativa entre la cámara y el cubo

    void LateUpdate()
    {
        // Actualiza la posición de la cámara para que siga al cubo, manteniendo el offset
        transform.position = target.position + offset;
    }
}
