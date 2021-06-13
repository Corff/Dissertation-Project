using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VignetteHandler : MonoBehaviour
{

    public CharacterController player;
    public VolumeProfile volume;
    private Vignette vg;

    private bool run; 
    
    // Start is called before the first frame update
    void Start()
    {
        volume.TryGet(out vg);
        GameObject runG = GameObject.FindGameObjectWithTag("vg");

        run = runG != null;
        
        if(!run)
            Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.velocity.magnitude > 0)
            vg.intensity.value = 0.5f;
        else
        {
            vg.intensity.value = 0.0f;
        }
    }
}