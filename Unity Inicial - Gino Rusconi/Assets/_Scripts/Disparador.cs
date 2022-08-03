using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefab;
    public string _tagTargetDamage;
    public string nombreAccion;
    public float _TimeBeetwenShoot;
    private float _LastTimeShoot;
    public GameObject _DistanciaSpawnBullet;

    private bool _IsShootingEnabled;

    private void Start()
    {
        _IsShootingEnabled = true;
    }
    void Update()
    {
        if (Input.GetButton(nombreAccion) && _IsShootingEnabled)
        {
            _LastTimeShoot = 0f;
            _IsShootingEnabled = false;
            Disparar();
        } 
        else if (_LastTimeShoot < _TimeBeetwenShoot)
        {
            _LastTimeShoot += Time.deltaTime;

            if (_LastTimeShoot >= _TimeBeetwenShoot)
            {
                _IsShootingEnabled = true;
            }
        }
        
    }

    void Disparar()
    {
        GameObject pref = Instantiate(prefab, _DistanciaSpawnBullet.transform.position, _DistanciaSpawnBullet.transform.rotation);
        prefab.gameObject.GetComponent<Dañador>()._TagTarget = _tagTargetDamage;
    }
}
