using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float _Speed;
    public float _turnSpeed;
    private Rigidbody _rb;
    public bool dead;
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
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.layer == 6)
        {
            //Destroy(this.gameObject);
            Debug.Log("there was a collision");
        }
    }
}
