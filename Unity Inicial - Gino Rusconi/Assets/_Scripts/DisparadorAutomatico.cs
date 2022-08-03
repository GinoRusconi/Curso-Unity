using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    public GameObject prefab;
    public string _tagTargetDamage;
    public float _TimeBetweenShoot;
    public GameObject _DistanciaSpawnBullet;

    void Awake()
    {
        InvokeRepeating("Disparar", 1f, _TimeBetweenShoot);
    }

    void Disparar()
    {
        GameObject pref = Instantiate(prefab, _DistanciaSpawnBullet.transform.position, _DistanciaSpawnBullet.transform.rotation);
        pref.gameObject.GetComponent<Dañador>()._TagTarget = _tagTargetDamage;
    }
}
