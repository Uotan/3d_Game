using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertesting : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        Debug.Log("triggered");
    }
    private void OnTriggerExit(Collider other) {
        
        Debug.Log("it's gone");
    }
    private void OnCollisionEnter(Collision other) {
        Debug.Log("it's gone");
    }
}
