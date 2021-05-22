using UnityEngine;
using UnityEngine.AI;

//This script uses Unity AI to apply to the Enemy. This script makes the enemy to be drawn to the player object.
//This Script uses NavMeshAgent and is attached to the Enemy Soldiers
//I followed a wireframe magazine article provided in our last Semesters Module Programming Principles to set the AI and NavMesh Agents

public class Movetoplayer : MonoBehaviour
{
    public Transform goal; //sets a goal for the enemys to be drawn to
    private NavMeshAgent agent; //sets the NavMesh Agent

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(goal.position); //this is the player
    }
}
