using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSetting : MonoBehaviour {

    public float rotationSpeed;
    float sunSpeed;

    public GameObject lightTracker;

    public GameObject playerHeadLights;
    public GameObject ai1HeadLights;
    public GameObject ai2HeadLights;
    public GameObject ai3HeadLights;


    /* 
    
    0.00007040895   = 24 hr/rotation
    0.0001408179    = 12 hr/rotation
    0.00416666666   = 24 min/rotation
    1               = 360 sec/rotation (degree a second)
    6               = 60 sec/rotation   
    
    
    
    
    */

    // Use this for initialization
    void Start () {
        sunSpeed = rotationSpeed * Time.deltaTime;
    }
	
	void FixedUpdate () {
        transform.Rotate(Vector3.right * sunSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (lightTracker.transform.position.y<=0)
        {
            playerHeadLights.SetActive(true);
            ai1HeadLights.SetActive(true);
            ai2HeadLights.SetActive(true);
            ai3HeadLights.SetActive(true);
        }
        else
        {
            playerHeadLights.SetActive(false);
            ai1HeadLights.SetActive(false);
            ai2HeadLights.SetActive(false);
            ai3HeadLights.SetActive(false);
        }
    }

}
