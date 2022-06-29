using UnityEngine;

public class RotacionContinua : MonoBehaviour
{
    public float velocidadX, velocidadY, velocidadZ;

    void Update()
    {
        this.transform.Rotate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ * Time.deltaTime);
    }
}
