using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHorizontal : MonoBehaviour
{
    Rigidbody _RigidBody;
    Vector3 _DirectionToMove;
    public float _SpeedMovement;
    public float _MaxSpeed;
    public float _TimeToSpeedUp;
    private float _NextSpeedUp;


    private void Awake()
    {
        _RigidBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        _DirectionToMove = Vector3.right;
        _NextSpeedUp = Time.time;
    }

    void Update()
    {
        if (Time.time > _NextSpeedUp)
        {
            _SpeedMovement++;
            _SpeedMovement = Mathf.Clamp(_SpeedMovement, 0.0f, _MaxSpeed);
            _NextSpeedUp = Time.time + _TimeToSpeedUp;
        }
    }

    private void FixedUpdate()
    {
        Vector3 force = Vector3.ClampMagnitude(_DirectionToMove * _SpeedMovement * Time.deltaTime, _MaxSpeed);
        _RigidBody.AddForce(force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Enemy")
        {
            _DirectionToMove *= -1;
        }
    }
}
