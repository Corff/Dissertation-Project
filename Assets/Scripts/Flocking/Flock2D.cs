using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock2D : MonoBehaviour
{

    public FlockAgent2D agentPrefab;
    private List<FlockAgent2D> agents = new List<FlockAgent2D>();
    public FlockBehaviour2D behaviour;

    [Range(1, 500)] public int startingCount = 250;
    public float AgentDensity = 0.08f;

    [Range(1f, 100f)] public float driveFactor = 10f;
    [Range(1f, 100f)] public float maxSpeed = 5f;
    [Range(1f, 10f)] public float neighbourRadius = 1.5f;
    [Range(0f, 1f)] public float avoidanceRadiusMultiplier = 0.5f;

    private float squareMaxSpeed;
    private float squareNeighbourRadius;
    private float squareAvoidanceRadius;

    public float SquareAvoidanceRadius
    {
        get { return squareAvoidanceRadius; }
    }

    // Start is called before the first frame update
    void Start()
    {
        squareMaxSpeed = Mathf.Pow(maxSpeed,2);
        squareNeighbourRadius = Mathf.Pow(neighbourRadius, 2);
        squareAvoidanceRadius = squareNeighbourRadius * Mathf.Pow(avoidanceRadiusMultiplier, 2);

        for (int i = 0; i < startingCount; i++)
        {
            FlockAgent2D newAgent = Instantiate(
                agentPrefab,
                Random.insideUnitCircle * startingCount * AgentDensity,
                Quaternion.Euler(Vector3.forward * Random.Range(0f,360f)),
                transform
                );
            newAgent.name = "Agent " + i;
            newAgent.transform.position += transform.position;
            newAgent.Initialize(this);
            agents.Add(newAgent);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (FlockAgent2D agent in agents)
        {
            List<Transform> context = GetNearbyObjects(agent);
            Vector2 move = behaviour.calculateMove(agent, context, this);
            move *= driveFactor;
            if (move.sqrMagnitude > squareMaxSpeed)
            {
                move = move.normalized * maxSpeed;
            }
            agent.Move(move);
        }
    }

    List<Transform> GetNearbyObjects(FlockAgent2D agent)
    {
        List<Transform> context = new List<Transform>();
        Collider2D[] contextColliders = Physics2D.OverlapCircleAll(agent.transform.position, neighbourRadius);
        foreach (Collider2D c in contextColliders)
        {
            if (c != agent.AgentCollider)
            {
                context.Add(c.transform);
            }
        }
        return context;
    }
}
