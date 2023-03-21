using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerZone : MonoBehaviour
{
    /*public float ZoneMovementSpeed = 1.0f;
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * ZoneMovementSpeed, transform.position.z);
        Debug.Log(Time.deltaTime);
    }*/

    private Rigidbody _rigidbody;
    public float ZoneMovementSpeed = 2.0f;

    private Vector3 _prevPosSpeed;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _prevPosSpeed = transform.position;
    }
    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(0, ZoneMovementSpeed, 0);
        _rigidbody.AddForce(new Vector3(0, ZoneMovementSpeed, 0), ForceMode.VelocityChange);
        //Debug.Log("Текущая скорость - " + (transform.position.y - _prevPosSpeed.y));
        //_prevPosSpeed = transform.position;
    }
}
