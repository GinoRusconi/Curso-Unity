using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadPowerUp : MonoBehaviour
{

    public int _Bonus;
    public GameObject _ParticleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MovimientoPersonaje movimienPersonaje = other.gameObject.GetComponent<MovimientoPersonaje>();
            movimienPersonaje.velocidadMovimiento += _Bonus;
            PowerUpUsed();
        }
    }
    
    private void PowerUpUsed()
    {
        Instantiate(_ParticleSystem, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
