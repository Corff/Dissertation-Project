using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create2DObstacle : MonoBehaviour
{
    
    public GameObject Counterpart2D;

    private GameObject alt;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mappedPosition = new Vector3(gameObject.transform.position.x,gameObject.transform.position.z,1000);
        alt = Instantiate(
            Counterpart2D,
            mappedPosition,
            Quaternion.identity,
            gameObject.transform
        );
    }
}
