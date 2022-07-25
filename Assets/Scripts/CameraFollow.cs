using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Player Player;
    public Vector3 PlayerToCameraOffset;

    void Start()
    {
        
    }
    
    void Update()
    {
        Vector3 position = Player.transform.position + PlayerToCameraOffset;
        transform.position = position;
    }
}
