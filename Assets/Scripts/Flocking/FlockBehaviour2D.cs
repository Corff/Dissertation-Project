using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class FlockBehaviour2D : ScriptableObject
{
    public abstract Vector2 calculateMove(FlockAgent2D agent, List<Transform> context, Flock2D flock);
}
