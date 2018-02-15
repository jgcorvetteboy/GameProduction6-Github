using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour {

    public GameObject myCar;
    public GameObject finishCam;
    public GameObject viewModes;
    public GameObject levelMusic;
    public GameObject completeTrig;

    public AudioSource finishMusic;

    void OnTriggerEnter()
    {
        myCar.SetActive(false);
        completeTrig.SetActive(false);
        CarController.carTopSpeed = 0.0f;
        myCar.GetComponent<CarController>().enabled = false;
        myCar.GetComponent<CarUserControl>().enabled = false;
        myCar.SetActive(true);
        finishCam.SetActive(true);
        levelMusic.SetActive(false);
        viewModes.SetActive(false);
        finishMusic.Play();
    }




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
