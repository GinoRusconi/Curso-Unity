using UnityEngine;
public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadMovimiento;
    public float velocidadRotacion;
    private float _directionHorizontal;
    private float _directionVertical;
    public float _maxSpeed;
    private Rigidbody _rigidbody;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        _directionHorizontal = Input.GetAxisRaw("Horizontal");
        //_directionVertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 direction = new Vector3(_directionHorizontal, 0 , 0);
        Vector3 force = Vector3.ClampMagnitude(direction * velocidadMovimiento * Time.deltaTime, _maxSpeed);
        _rigidbody.AddForce(force);
    }



}