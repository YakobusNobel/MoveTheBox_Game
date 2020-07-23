using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform player;

    public Vector3 newpos;

    void Update() {
        transform.position = player.position + newpos;    
    }
}
