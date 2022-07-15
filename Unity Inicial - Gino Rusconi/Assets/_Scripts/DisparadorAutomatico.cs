using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    public GameObject prefab;
    public float _TimeBetweenShoot;
    public float _DistanciaSpawnBullet;

    void Awake()
    {
        InvokeRepeating("Disparar", 1f, _TimeBetweenShoot);
    }

    void Disparar()
    {
        Instantiate(prefab, transform.position + (transform.forward * _DistanciaSpawnBullet), transform.rotation);
    }
}
