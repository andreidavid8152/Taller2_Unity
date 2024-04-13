using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;    // La distancia y dirección relativa entre la cámara y el cubo

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
