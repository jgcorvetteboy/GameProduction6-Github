using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject cameraMain;
    public GameObject cameraFar;
    public GameObject cameraFPS;
    public int camMode;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("ViewMode"))
        {
            if (camMode == 2)
            {
                camMode = 0;
            }
            else
            {
                camMode++;
            }
            StartCoroutine(ModeChange());
        }
	}

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (camMode == 0)
        {
            cameraMain.SetActive(true);
            cameraFPS.SetActive(false);
        }
        else if (camMode == 1)
        {
            cameraFar.SetActive(true);
            cameraMain.SetActive(false);
        }
        else if (camMode == 2)
        {
            cameraFPS.SetActive(true);
            cameraFar.SetActive(false);
        }
    }
}
