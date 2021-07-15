using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forRoad : MonoBehaviour
{
    public bool _playerontheroad;
    public GameObject [] prefabs;


    public void CheckCollisions()
    {
        int _prefabNumb = Random.Range(0, prefabs.Length);
        if (_playerontheroad == false)
        {
            Instantiate(prefabs[_prefabNumb], new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z+200f), Quaternion.identity);
            Destroy(this.gameObject);
        }
        
    }

}
