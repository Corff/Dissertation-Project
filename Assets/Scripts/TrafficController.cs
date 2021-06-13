using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficController : MonoBehaviour
{

    public GameObject trafficLight1;
    public GameObject trafficLight2;
    public GameObject trafficLight3;
    public GameObject trafficLight4;

    private int num = 1;

    public float delay;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cycle(num));
    }

    IEnumerator cycle(int numb)
    {
        if (numb == 3)
        {
            numb = 1;
            num = 1;
        }
        if (numb == 1)
        {
            //light 1 green
            trafficLight1.transform.GetChild(0).gameObject.SetActive(true);//green
            trafficLight1.transform.GetChild(1).gameObject.SetActive(false);//red
            //light 2 green
            trafficLight2.transform.GetChild(0).gameObject.SetActive(true);//green
            trafficLight2.transform.GetChild(1).gameObject.SetActive(false);//red
            //light 3 red
            trafficLight3.transform.GetChild(0).gameObject.SetActive(false);//green
            trafficLight3.transform.GetChild(1).gameObject.SetActive(true);//red
            //light 4 red
            trafficLight4.transform.GetChild(0).gameObject.SetActive(false);//green
            trafficLight4.transform.GetChild(1).gameObject.SetActive(true);//red
        }
        else if (numb == 2)
        {
            //light 1 red
            trafficLight1.transform.GetChild(0).gameObject.SetActive(false);//green
            trafficLight1.transform.GetChild(1).gameObject.SetActive(true);//red
            //light 2 red
            trafficLight2.transform.GetChild(0).gameObject.SetActive(false);//green
            trafficLight2.transform.GetChild(1).gameObject.SetActive(true);//red
            //light 3 green
            trafficLight3.transform.GetChild(0).gameObject.SetActive(true);//green
            trafficLight3.transform.GetChild(1).gameObject.SetActive(false);//red
            //light 4 green
            trafficLight4.transform.GetChild(0).gameObject.SetActive(true);//green
            trafficLight4.transform.GetChild(1).gameObject.SetActive(false);//red
        }

        num++;
        yield return new WaitForSeconds(delay);
        StartCoroutine(cycle(num));
    }
}
