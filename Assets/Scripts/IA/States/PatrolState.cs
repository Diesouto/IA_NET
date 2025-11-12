using System;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) PatrolState", menuName = "ScriptableObjects/States/PatrolState")]
public class Patrol : State
{
    [SerializeField] private Vector3[] patrolPositions;
    private int index;

    void Start()
    {
        index = 0;
    }

    public override State Run(GameObject owner)
    {
        NavMeshAgent agentCmp = owner.GetComponent<NavMeshAgent>();

        if (agentCmp.remainingDistance <= agentCmp.stoppingDistance)
        {
            agentCmp.SetDestination(patrolPositions[index]);
            index = (index + 1) % patrolPositions.Length;
        }

        return base.Run(owner);
    }
}