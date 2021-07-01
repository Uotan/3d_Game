using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float _Speed;
    public float _turnSpeed;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float _moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 _movement = new Vector3(_moveHorizontal, 0f, 0f);
        turn(_movement);
    }
    private void FixedUpdate()
    {
        _rb.AddForce(Vector3.forward*_Speed);
    }
    void turn(Vector3 _turnControl)
    {
        _rb.AddForce(_turnControl * _turnSpeed);
    }
}
