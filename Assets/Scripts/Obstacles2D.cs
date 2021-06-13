using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles2D : MonoBehaviour
{
    public GameObject building;
    private GameObject alt;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 mappedPositon = new Vector3(gameObject.transform.position.x,0.01f,gameObject.transform.position.y);
        alt = Instantiate(
            building,
            mappedPositon,
            Quaternion.identity,
            gameObject.transform
            );
        //Destroy(this);
    }

    void Update()
    {
        alt.transform.position = new Vector3(gameObject.transform.position.x, 0.01f, gameObject.transform.position.y);
    }
}
