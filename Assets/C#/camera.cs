using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;
    public Vector3 _cameraposition;

    void Update()
    {
        Vector3 playerPos = player.transform.position;
        this.gameObject.transform.position = new Vector3(playerPos.x, playerPos.y+_cameraposition.y, playerPos.z-_cameraposition.z);
    }
}
