using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public bool _collisioned;
    //Удалить родительский объект т.е. всю дорожку с препятствиями
    public forRoad _parrentGOscript;
    public float waittime = 10f;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "playerCollider")
        {
            _parrentGOscript._playerontheroad = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "playerCollider")
        {
            _parrentGOscript._playerontheroad = false;
            Invoke("Check", waittime);
        }
    }
    void Check()
    {
        _parrentGOscript.CheckCollisions();
    }

}

