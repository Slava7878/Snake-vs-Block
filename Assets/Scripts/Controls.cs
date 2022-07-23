using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public Rigidbody Player;    

    public float Sensitivity;

    Vector3 initialPosition;
    
    private float _distance;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            initialPosition = transform.position;
            Vector3 rayPoint = ray.GetPoint(0);
            _distance = Vector3.Distance(transform.position, rayPoint);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 rayPoint = ray.GetPoint(_distance * Sensitivity);
            Player.MovePosition(initialPosition + new Vector3(rayPoint.x, 0, 0));
        }
    }    
}
