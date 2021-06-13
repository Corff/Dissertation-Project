using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAgents : MonoBehaviour
{

    public GameObject[] agents;
    private GameObject start, end;

    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("2DAgent");
        start = GameObject.FindGameObjectWithTag("Start");
        end = GameObject.FindGameObjectWithTag("End");
    }

    void Update()
    {
        foreach (GameObject agent in agents)
        {
            if (agent.transform.position.x >= start.transform.position.x &&
                agent.transform.position.x <= end.transform.position.x)
            {
                if (agent.transform.position.y < start.transform.position.y &&
                    agent.transform.position.y > end.transform.position.y)
                {
                    agent.GetComponent<Control3D>().alt.SetActive(false);
                    agent.SetActive(false);
                }
            }
        }
    }
}
