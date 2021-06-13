using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock2D/Behaviour2D/Composite2D")]
public class CompositeBehaviour2D : FlockBehaviour2D
{

    public FlockBehaviour2D[] behaviours;
    public float[] weights;
    
    public override Vector2 calculateMove(FlockAgent2D agent, List<Transform> context, Flock2D flock)
    {
        if (weights.Length != behaviours.Length)
        {
            Debug.LogError("Data mismatch in " + name, this);
            return Vector2.zero;
        }
        Vector2 move = Vector2.zero;
        for (int i = 0; i < behaviours.Length; i++)
        {
            Vector2 partialMove = behaviours[i].calculateMove(agent, context, flock) * weights[i];

            if (partialMove != Vector2.zero)
            {
                if (partialMove.sqrMagnitude > Mathf.Pow(weights[i], 2))
                {
                    partialMove.Normalize();
                    partialMove *= weights[i];
                }

                move += partialMove;
            }
        }

        return move;

    }
}
