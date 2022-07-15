using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorTemporizado : MonoBehaviour
{
    public float _TimeToAutoDestruccion;
    private void Awake()
    {
        Invoke("AutoDestruir", _TimeToAutoDestruccion);
    }

    void AutoDestruir()
    {
        Destroy(gameObject);
    }

}
