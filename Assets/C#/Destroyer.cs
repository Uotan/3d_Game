using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public bool _collisioned;
    private void OnCollisionExit(Collision other) {
        if (other.gameObject.tag=="Player")
        {
             _collisioned = false;
            StartCoroutine("DoCheck");
        }
    }
    private void OnCollisionStay(Collision other) {
        if (other.gameObject.tag=="Player")
        {
            _collisioned = true;
        }
    }
    IEnumerator DoCheck() 
    {
        yield return new WaitForSeconds(20f);
        if (_collisioned==false)
        {
            Destroy(this.gameObject);
        }
    }
}

