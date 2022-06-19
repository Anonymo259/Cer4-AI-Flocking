using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/AvoidPlayer")]


public class AvoidPlayer : FlockBehavior
{


    
    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector2 avoidanceMove = Vector2.zero;
        avoidanceMove += (Vector2)(agent.transform.position - (Vector3)GameManager.playerPosition); //to go away something, current position - player

        return avoidanceMove; //output
        
    }





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
