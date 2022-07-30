using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailGoal : MonoBehaviour
{    
    public Vector3 Goal;

    void Start()
    {
        
    }
    
    void Update()
    {
        GoalPosition();
    }

    public void GoalPosition()
    {        
        Goal = transform.position;        
    }
}
