using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int _Cantidad;
    public GameObject _ParticleExplotion;
    public GameObject[] _ParticleDamage;
    private int particleDamagable;

    private void Start()
    {
        particleDamagable = 0;
    }
    void Update()
    {
        if (_Cantidad <= 0)
        {
            SendMessage("Mori");
            Instantiate(_ParticleExplotion, gameObject.transform.position, _ParticleExplotion.transform.rotation);
            Destroy(gameObject);
        }
    }

    public void GetDamage(int dmg)
    {
        _Cantidad -= dmg;
        if (_ParticleDamage.Length > particleDamagable)
        {
            _ParticleDamage[particleDamagable].SetActive(true);
            particleDamagable++;
        }
    }
}
