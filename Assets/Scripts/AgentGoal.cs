using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentGoal : MonoBehaviour
{
    //public Transform Goal;
    TailGoal tailGoal;

    void Start()
    {
        //tailGoal = FindObjectOfType<TailGoal>();
        //NavMeshAgent agent = GetComponent<NavMeshAgent>();
        
        //agent.destination = Goal.position;
    }
    private void Update()
    {
        tailGoal = FindObjectOfType<TailGoal>();
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = tailGoal.Goal;
    }
}
