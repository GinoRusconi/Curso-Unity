using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoContinuo : MonoBehaviour
{
    public float velocidadX, velocidadY, velocidadZ;

    void Update()
    {
        this.transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ * Time.deltaTime);
    }
}
