using UnityEngine;
public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadMovimiento;
    public float velocidadRotacion;

    void Update()
    {
        if (Input.GetButtonDown("Arriba"))
        {
            this.transform.Translate(0, 0, velocidadMovimiento * Time.deltaTime);
        }
        if (Input.GetButtonDown("Abajo"))
        {
            this.transform.Translate(0, 0, -(velocidadMovimiento * Time.deltaTime));
        }
        if (Input.GetButtonDown("Izquierda"))
        {
            this.transform.Rotate(0, velocidadRotacion * Time.deltaTime, 0);
        }
        if (Input.GetButtonDown("Derecha"))
        {
            this.transform.Rotate(0, -(velocidadRotacion * Time.deltaTime), 0);
        }
    }
}