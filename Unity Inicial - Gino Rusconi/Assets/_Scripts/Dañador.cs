using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dañador : MonoBehaviour
{
    public int _Daño;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Enemy")
        {
            Vida vida = other.gameObject.GetComponent<Vida>();
            vida._Cantidad -= _Daño;
            Destroy(gameObject);
        }
    }
}
