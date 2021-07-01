using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        Vector3 playerPos = player.transform.position;
        this.gameObject.transform.position = new Vector3(playerPos.x, 8.78f, playerPos.z-6);
    }
}
