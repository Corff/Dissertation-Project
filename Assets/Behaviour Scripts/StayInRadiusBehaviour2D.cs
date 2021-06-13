using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Flock2D/Behaviour2D/Stay In Radius 2D")]
public class StayInRadiusBehaviour2D : FlockBehaviour2D
{

    public Vector2 centre;
    public float radius = 15f;
    
    public override Vector2 calculateMove(FlockAgent2D agent, List<Transform> context, Flock2D flock)
    {
        Vector2 centreOffset = centre - (Vector2) agent.transform.position;
        float t = centreOffset.magnitude / radius;

        if (t < 0.9f)
        {
            return Vector2.zero;
        }

        return centreOffset * Mathf.Pow(t, 2);
    }
}
