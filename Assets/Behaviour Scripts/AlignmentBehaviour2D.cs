using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock2D/Behaviour2D/Alignment2D")]
public class AlignmentBehaviour2D : FlockBehaviour2D
{
    public override Vector2 calculateMove(FlockAgent2D agent, List<Transform> context, Flock2D flock)
    {
        
        if (context.Count == 0)
            return agent.transform.up;

        Vector2 alignmentMove = Vector2.zero;

        foreach (Transform item in context)
        {
            alignmentMove += (Vector2) item.transform.up;
        }

        alignmentMove /= context.Count;

        return alignmentMove;
    }
}
