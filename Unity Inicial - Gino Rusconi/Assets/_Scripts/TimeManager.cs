using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float _TiempoDesdeAwake;

    // Update is called once per frame
    private void Awake()
    {
        _TiempoDesdeAwake = Time.deltaTime;
    }

    void Update()
    {
        _TiempoDesdeAwake += Time.deltaTime;    
    }
}
