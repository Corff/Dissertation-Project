using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAvoid : MonoBehaviour
{
    public GameObject[] startEndPrefab;

    private Vector3 start, end, topPointer, bottomPointer, leftPointer, rightPointer;

    private bool done, top, bottom, left, right;

    public destroyAgents dA;

    public float iterator = 0.25f;


    // Start is called before the first frame update
    void Start()
    {

        start = startEndPrefab[0].transform.position;
        end = startEndPrefab[1].transform.position;

        topPointer = new Vector3(start.x, start.y, 1000);
        bottomPointer = new Vector3(start.x, end.y, 1000);
        leftPointer = topPointer;
        rightPointer = new Vector3(end.x, start.y, 1000);

    }

    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            //Row 1 (Top -> +x)
            if (!top)
            {
                Instantiate(
                    startEndPrefab[2],
                    topPointer,
                    Quaternion.identity,
                    gameObject.transform
                );
                topPointer = new Vector3(topPointer.x + iterator, topPointer.y, topPointer.z);
                if (topPointer.x >= end.x)
                    top = true;
            }
            //Row 2 (Bottom -> +x)

            if (!bottom)
            {

                Instantiate(
                    startEndPrefab[2],
                    bottomPointer,
                    Quaternion.identity,
                    gameObject.transform
                );

                bottomPointer = new Vector3(bottomPointer.x + iterator, bottomPointer.y, bottomPointer.z);

                if (bottomPointer.x >= end.x)
                    bottom = true;
            }

            //Column 1 (Left \/ -y)

            if (!left)
            {

                Instantiate(
                    startEndPrefab[2],
                    leftPointer,
                    Quaternion.identity,
                    gameObject.transform
                );

                leftPointer = new Vector3(leftPointer.x, leftPointer.y - iterator, leftPointer.z);

                if (leftPointer.y <= end.y)
                    left = true;
            }

            //Column 2 (Right \/ -y)

            if (!right)
            {

                Instantiate(
                    startEndPrefab[2],
                    rightPointer,
                    Quaternion.identity,
                    gameObject.transform
                );

                rightPointer = new Vector3(rightPointer.x, rightPointer.y - iterator, rightPointer.z);

                if (rightPointer.y <= end.y)
                    right = true;
            }

            if (top && bottom && left && right)
                done = true;
        }

        if (done)
        {
            //dA.enabled = true;
            Destroy(this);
        }
    }
}
