using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailPart : MonoBehaviour
{    
    public float FollowSpeed;    

    TailGoal tailGoal;

    void Start()
    {
        tailGoal = FindObjectOfType<TailGoal>();
    }
    
    void Update()
    {        
        FollowGoal();
    }

    public void FollowGoal()
    {
        transform.position = Vector3.MoveTowards(transform.position, tailGoal.Goal, FollowSpeed * Time.deltaTime);
        
        //transform.Translate(tailGoal.Goal * (FollowSpeed * Time.deltaTime));
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    FollowGoal();
    //}
}
