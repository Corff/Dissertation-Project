using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control3D : MonoBehaviour
{

    public GameObject[] Prefab3Ds;
    public GameObject alt;
    
    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(0, Prefab3Ds.Length);
        Vector3 mappedPosition = new Vector3(gameObject.transform.position.x,1,gameObject.transform.position.y);
        alt = Instantiate(
            Prefab3Ds[num],
            mappedPosition,
            Quaternion.Euler(transform.forward)
            );
        alt.transform.SetParent(GameObject.FindGameObjectWithTag("3DAgents").transform);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mappedPosition = new Vector3(gameObject.transform.position.x,0,gameObject.transform.position.y);
        alt.transform.position = mappedPosition;
        
        
        Quaternion mappedRotation = new Quaternion(0,gameObject.transform.eulerAngles.z,0,0);
        //Debug.Log(gameObject.transform.eulerAngles.z);
        alt.transform.rotation = Quaternion.Euler(0,-gameObject.transform.eulerAngles.z,0);
        //alt.transform.rotation = Quaternion.Euler(gameObject.transform.forward);
    }
}
