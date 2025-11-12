using UnityEngine;
using UnityEngine.AI;

public class CatMovement : MonoBehaviour
{
    [SerializeField] Vector3 position;
    [SerializeField] GameObject player;

    private NavMeshAgent agentCmp;
    private Vector3[] patrolPositions;
    private Transform playerPosition;
    private int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agentCmp = GetComponent<NavMeshAgent>();

        // Move to initial position
        //agentCmp.SetDestination(position);


        // Define patrol positions
        patrolPositions = new Vector3[]
        {
            new Vector3(5f, 0f, 5f),
            new Vector3(5f, 0f, -5f),
            new Vector3(-5f, 0f, -5f),
            new Vector3(-5f, 0f, 5f)
        };
    }

    // Update is called once per frame
    void Update()
    {
        // Move towards the player
        //playerPosition = player.transform;
        //agentCmp.SetDestination(playerPosition.position);


        // Patrol between positions
        agentCmp.SetDestination(patrolPositions[index]);

        if(agentCmp.remainingDistance < agentCmp.stoppingDistance)
        {
            index = (index + 1) % patrolPositions.Length;
        }
    }
}
