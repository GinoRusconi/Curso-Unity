using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int _Cantidad;

    void Update()
    {
        if (_Cantidad <= 0)
        {
            SendMessage("Mori");
            Destroy(gameObject);
        }
    }
}
