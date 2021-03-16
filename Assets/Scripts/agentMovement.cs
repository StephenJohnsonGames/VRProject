using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agentMovement : MonoBehaviour
{
    private NavMeshAgent NPC;
    public Transform[] waypoints;
    private int nextDest = 0;
  

    // Start is called before the first frame update
    void Start()
    {
        NPC = GetComponent<NavMeshAgent>();
        //NPC.autoBraking = false; using autobraking actually chokes up the agent intermittently

        goToPoint();
    }
    void goToPoint()
    {
        if (waypoints.Length == 0) return; //If nothing has been set up return


        //Set up the NPC first point
        NPC.destination = waypoints[nextDest].position;

        //Next destination is the next point in the array and if no more go back to start 
        nextDest = (nextDest + 1) % waypoints.Length;

    }
    // Update is called once per frame
    void Update()
    {

       
        //Go to the next destination when you are close to the current one 
        if (!NPC.pathPending && NPC.remainingDistance < 0.5f)
        {
            
            goToPoint();
        }

        
     
        
    }

    
}
