using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Vector3 Acceleration;

    //void Start()
    //{
    //    Rigidbody = GetComponent<Rigidbody>();
    //}

    void FixedUpdate()
    {
        Rigidbody.AddForce(Acceleration, ForceMode.Acceleration);
    }
}
