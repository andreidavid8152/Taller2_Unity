using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;    // La distancia y direcci�n relativa entre la c�mara y el cubo

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
