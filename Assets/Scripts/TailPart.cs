using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailPart : MonoBehaviour
{    
    public float FollowSpeed;
    public float Acceleration;

    TailGoal tailGoal;

    Rigidbody m_Rigidbody;
    private Vector3 movement;

    //void Start()
    //{
    //    tailGoal = FindObjectOfType<TailGoal>();
    //    m_Rigidbody = GetComponent<Rigidbody>();
    //}

    //void Update()
    //{        
    //    Vector3 direction = tailGoal.Goal - transform.position;
    //    direction.Normalize();
    //    movement = direction;
    //}

    //public void FollowGoal(Vector3 direction)
    //{
    //    m_Rigidbody.MovePosition(transform.position + (direction * Time.deltaTime * (FollowSpeed + Acceleration)));        
    //}    

    //private void FixedUpdate()
    //{
    //    FollowGoal(movement);
    //}

    public void DestroyTail()
    {
        Destroy(gameObject);
    }
}
