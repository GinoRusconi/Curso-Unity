using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dañador : MonoBehaviour
{
    public int _Daño;
    public string _TagTarget;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Vida>())
        {
            if (other.tag == _TagTarget || other.tag == "Wall")
            {
                Vida vida = other.gameObject.GetComponent<Vida>();
                vida._Cantidad -= _Daño;
                Destroy(gameObject);
            }
        }
    }
}
