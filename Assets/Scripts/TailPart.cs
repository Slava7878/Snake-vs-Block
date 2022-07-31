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

    void Start()
    {
        tailGoal = FindObjectOfType<TailGoal>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //FollowGoal();
        Vector3 direction = tailGoal.Goal - transform.position;
        direction.Normalize();
        movement = direction;
    }

    public void FollowGoal(Vector3 direction)
    {
        //transform.position = Vector3.MoveTowards(transform.position, tailGoal.Goal, FollowSpeed * Acceleration * Time.deltaTime);
        //transform.Translate(tailGoal.Goal * (FollowSpeed * Time.deltaTime));

        m_Rigidbody.MovePosition(transform.position + (direction * Time.deltaTime * (FollowSpeed + Acceleration)));

        //float distance = Vector3.Distance(tailGoal.Goal, transform.position);
        //if (distance > 2)
        //{
        //    Acceleration++;
        //}
        //if (distance <= 2)
        //{
        //    Acceleration = 1;
        //}
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    FollowGoal();
    //}

    private void FixedUpdate()
    {
        FollowGoal(movement);
    }

    public void DestroyTail()
    {
        Destroy(gameObject);
    }
}
