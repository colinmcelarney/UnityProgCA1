using UnityEngine;
using UnityEngine.AI;
//This script uses Unity AI to apply to the Enemy. This script makes the enemy to be drawn to the player object
public class Movetoplayer : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;
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
