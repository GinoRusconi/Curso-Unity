using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefab;
    public string nombreAccion;
    public float _TimeBeetwenShoot;
    void Update()
    {
        if (Input.GetButtonDown(nombreAccion))
        {
            InvokeRepeating("Disparar", 0, _TimeBeetwenShoot);
        }
        if (Input.GetButtonUp(nombreAccion))
        {
            CancelInvoke("Disparar");
        }
    }

    void Disparar()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
