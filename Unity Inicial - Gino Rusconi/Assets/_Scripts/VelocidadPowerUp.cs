using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadPowerUp : MonoBehaviour
{

    public int _Bonus;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MovimientoPersonaje movimienPersonaje = other.gameObject.GetComponent<MovimientoPersonaje>();
            movimienPersonaje.velocidadMovimiento += _Bonus;
        }
    }
}
