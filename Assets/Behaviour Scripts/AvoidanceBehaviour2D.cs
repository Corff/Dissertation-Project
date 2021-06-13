using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock2D/Behaviour2D/Avoidance2D")]
public class AvoidanceBehaviour2D : FlockBehaviour2D
{
    public override Vector2 calculateMove(FlockAgent2D agent, List<Transform> context, Flock2D flock)
    {

        if (context.Count == 0)
            return Vector2.zero;
        
        Vector2 avoidanceMove = Vector2.zero;
        int nAvoid = 0;

        //List<Transform> filteredContext = (filter == null) ? context : filter.Filter(agent, context);
        foreach (Transform item in context)
        {
            if (Vector2.SqrMagnitude(item.position - agent.transform.position) < flock.SquareAvoidanceRadius)
            {
                nAvoid++;
                avoidanceMove += (Vector2) (agent.transform.position - item.position);
            }
        }

        if (nAvoid > 0)
            avoidanceMove /= nAvoid;

        return avoidanceMove;

    }
}
