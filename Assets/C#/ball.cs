using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    public float _Speed;
    public float _speep_increment;
    public float _turnSpeed;
    public float _impuseForce;
    public float _impuseForceUP;

    private Rigidbody _rb;
    public bool _canbedead = true;
    public Vector3 _startPos;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _startPos = this.gameObject.transform.position;
    }

    private void FixedUpdate()
    {
        float _moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 _movement = new Vector3(_moveHorizontal, 0f, 0f);
        turn(_movement);
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            //Application.Quit();
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            _rb.AddForce(Vector3.forward * _impuseForce, ForceMode.Impulse);
        }

        _rb.AddForce(Vector3.forward*_Speed);
    }
    void turn(Vector3 _turnControl)
    {
        _rb.AddForce(_turnControl * _turnSpeed);
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.layer == 6&&_canbedead==true)
        {
            //Destroy(this.gameObject);
            SceneManager.LoadScene(0);
            //Debug.Log("there was a collision");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "speed_plus": _Speed += _speep_increment; _turnSpeed+= _speep_increment; break;
            case "speed_minus": _Speed -= _speep_increment;_turnSpeed-= _speep_increment; break;
            case "booster": _rb.AddForce(Vector3.forward * _impuseForce, ForceMode.Impulse); break;
            case "boost_up": _rb.AddForce(Vector3.up * _impuseForceUP, ForceMode.Impulse); break;
            case "deletezone": SceneManager.LoadScene(0); break;
            default: break;
        }
    }
}
