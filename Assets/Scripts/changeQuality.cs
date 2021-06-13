using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class changeQuality : MonoBehaviour
{
    public Text text;
    public RenderPipelineAsset[] levels;
    public VolumeProfile[] vProfiles;

    //private GameObject PostProcessingVolume;
    private Volume volume;
    
    // Start is called before the first frame update
    void Start()
    {
        volume = GameObject.FindGameObjectWithTag("PostProcessing").GetComponent<Volume>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            QualitySettings.SetQualityLevel(0);
            volume.profile = vProfiles[0];
            text.text = "low";
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            QualitySettings.SetQualityLevel(1);
            volume.profile = vProfiles[1];
            text.text = "medium";
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            QualitySettings.SetQualityLevel(2);
            volume.profile = vProfiles[2];
            text.text = "high";
        }
    }
}
