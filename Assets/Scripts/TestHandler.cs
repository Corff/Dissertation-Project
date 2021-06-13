using System.Collections;
using System.Collections.Generic;
using Oculus.Platform.Samples.VrBoardGame;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestHandler : MonoBehaviour
{

    public VolumeProfile profile;
    
    public void runTest1() //Low Graphics
    {
        QualitySettings.SetQualityLevel(0);
        SceneManager.LoadScene(1);
    }    
    public void runTest2() //Medium Graphics
    {
        QualitySettings.SetQualityLevel(1);
        SceneManager.LoadScene(1);
    }
    public void runTest3() //High Graphics
    {
        QualitySettings.SetQualityLevel(2);
        SceneManager.LoadScene(1);
    }

    public void runTestBloom()
    {
        setPP(0);
        SceneManager.LoadScene(1);
    }

    public void runTestChromAb()
    {
        setPP(1);
        SceneManager.LoadScene(1);
    }

    public void runTestDoF()
    {
        setPP(2);
        SceneManager.LoadScene(1);
    }

    public void runTestVig()
    {
        setPP(3);
        GameObject gam = Instantiate(new GameObject());
        gam.tag = "vg";
        DontDestroyOnLoad(gam);
        SceneManager.LoadScene(1);
    }
    
    void setPP(int num)
    {
        for (int i = 0; i < profile.components.Count; i++)
        {
            profile.components[i].active = i == num;
        }
    }

}
