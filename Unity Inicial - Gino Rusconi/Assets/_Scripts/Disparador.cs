using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefab;
    public string _tagTargetDamage;
    public string nombreAccion;
    public float _TimeBeetwenShoot;
    public float _DistanciaSpawnBullet;
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
        GameObject prefb = Instantiate(prefab, transform.position + (transform.forward * _DistanciaSpawnBullet), transform.rotation);
        prefab.gameObject.GetComponent<Dañador>()._TagTarget = _tagTargetDamage;
    }
}
