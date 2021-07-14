using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forRoad : MonoBehaviour
{
    public bool _playerontheroad;
    public GameObject prefab;

    public void CheckCollisions()
    {
        if (_playerontheroad == false)
        {
            Instantiate(prefab, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z+200f), Quaternion.identity);
            Destroy(this.gameObject);
        }
        
    }

}
