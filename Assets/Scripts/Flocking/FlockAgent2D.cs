using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class FlockAgent2D : MonoBehaviour
{

    
    private Collider2D agentCollider;
    private Flock2D agentFlock;
    public Flock2D AgentFlock { get { return agentFlock; } }

    public Collider2D AgentCollider
    {
        get { return agentCollider; }
    }

    void Start()
    {
        agentCollider = GetComponent<Collider2D>();
    }

    public void Initialize(Flock2D flock)
    {
        agentFlock = flock;
    }
    
    public void Move(Vector2 velocity)
    {
        transform.up = velocity;
        transform.position += (Vector3) velocity * Time.deltaTime;
    }

}
