using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputTestHandler : MonoBehaviour
{

    public float num = 120.0f;
    private void Start()
    {
        StartCoroutine(endTest());
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
            //UnityEditor.EditorApplication.isPlaying = false;
        if (OVRInput.Get(OVRInput.RawButton.X))
            SceneManager.LoadScene(0);
    }

    IEnumerator endTest()
    {
        yield return new WaitForSeconds(num);
        SceneManager.LoadScene(0);
    }
}
