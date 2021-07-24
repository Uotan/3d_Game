using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public forRoad _parrentGOscript;
    float waittime = 2f;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "playerCollider")
        {
            Invoke("Check", waittime);
        }
    }
    void Check()
    {
        _parrentGOscript.CheckCollisions();
    }

}

