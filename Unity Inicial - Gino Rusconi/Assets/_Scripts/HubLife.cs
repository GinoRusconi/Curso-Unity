using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HubLife : MonoBehaviour
{
    private Vida _PlayerLife;
    private Image _BarraDeVida;
    private int _MaxLife;
    public float timeToLerp;

    float _currentPorcentaje;

    private void Awake()
    {
        _PlayerLife = FindObjectOfType<Player>().GetComponent<Vida>();
        _BarraDeVida = GetComponent<Image>();
        _MaxLife = _PlayerLife._Cantidad;
    }

    // Update is called once per frame
    void Update()
    {
        _currentPorcentaje = _PlayerLife._Cantidad;
        _BarraDeVida.fillAmount = Mathf.Lerp(_BarraDeVida.fillAmount,(float)_PlayerLife._Cantidad / _MaxLife,timeToLerp);
        
    }
}
