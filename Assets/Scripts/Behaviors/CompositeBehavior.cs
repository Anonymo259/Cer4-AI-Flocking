using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock/Behavior/Composite")]
//ill show you next time i come "in person"
public class CompositeBehavior : FlockBehavior
{
    [System.Serializable]

    public struct BehaviourGroup
    {
        public FlockBehavior behavior;
        public float weights;
    }
    public BehaviourGroup[] behaviors;

    public override Vector2 CalculateMove(FlockAgent agent, List<Transform> context, Flock flock)
    {
        Vector2 move = Vector2.zero;

        foreach (BehaviourGroup behave in behaviors)
        {
            Vector2 partialMove = behave.behavior.CalculateMove(agent, context, flock) * behave.weights;

            if(partialMove != Vector2.zero)
            {
                if (partialMove.sqrMagnitude > behave.weights * behave.weights)
                {
                    partialMove.Normalize();
                    partialMove *= behave.weights;
                }
            }

            move += partialMove;
        }
        return move;
    }

}


