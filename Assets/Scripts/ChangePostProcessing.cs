using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ChangePostProcessing : MonoBehaviour
{

    public VolumeProfile profile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Bloom
            profile.components[0].active = !profile.components[0].active;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //Chromatic Aberration
            profile.components[1].active = !profile.components[1].active;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Depth Of Field
            profile.components[2].active = !profile.components[2].active;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //Motion Blur
            profile.components[3].active = !profile.components[3].active;
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            //Vignette
            profile.components[4].active = !profile.components[4].active;
        }
    }

}
