using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    //public Rigidbody Player;
    //public float Sensitivity;
    //Vector3 initialPosition;
    //private float _distance;

    public Transform PlayerObj;
    public float Speed;

    void Update()
    {
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    initialPosition = transform.position;
        //    Vector3 rayPoint = ray.GetPoint(0);
        //    _distance = Vector3.Distance(transform.position, rayPoint);
        //}

        //if (Input.GetMouseButton(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    Vector3 rayPoint = ray.GetPoint(_distance * Sensitivity);
        //    Player.MovePosition(initialPosition + new Vector3(rayPoint.x, 0, 0));
        //}

        if (Input.GetKey(KeyCode.A))
        {
            PlayerObj.position += -PlayerObj.right * (Time.deltaTime * Speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            PlayerObj.position += PlayerObj.right * (Time.deltaTime * Speed);
        }
    }    
}
