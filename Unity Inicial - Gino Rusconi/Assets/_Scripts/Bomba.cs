using UnityEngine;

public class Bomba : MonoBehaviour
{
    public bool _Explotar;
    public float _TimeToActivate;
    private void Awake()
    {
        Invoke("ActivarBomba", _TimeToActivate);
        _Explotar = false;

    }

    void Update()
    {
        if (Input.GetButtonDown("Explotar"))
        {
            _Explotar = true;
        }
    }

    void ActivarBomba()
    {
        _Explotar = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (_Explotar && (other.CompareTag("Player") || other.CompareTag("Enemy")))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
