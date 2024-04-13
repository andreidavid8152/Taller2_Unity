using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    public float scaleIncrease = 0.1f;

    public void IncreaseScale()
    {
        transform.localScale += new Vector3(scaleIncrease, scaleIncrease, scaleIncrease);  // Aumenta la escala en todas las direcciones
    }
}
