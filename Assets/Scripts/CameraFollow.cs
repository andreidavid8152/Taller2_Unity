using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // El objetivo que la c�mara seguir�, asigna esto al cubo en el inspector
    public Vector3 offset;    // La distancia y direcci�n relativa entre la c�mara y el cubo

    void LateUpdate()
    {
        // Actualiza la posici�n de la c�mara para que siga al cubo, manteniendo el offset
        transform.position = target.position + offset;
    }
}
