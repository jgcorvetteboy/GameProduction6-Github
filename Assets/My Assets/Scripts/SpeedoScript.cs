using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedoScript : MonoBehaviour {

    public GameObject speedBox;
    public GameObject playerCar;
    public float speed;
    //public int speedInt;

    // Use this for initialization
    void Start () {
        speed = Mathf.RoundToInt (GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().CurrentSpeed);

    }
	
	// Update is called once per frame
	void Update () {
        speed = Mathf.RoundToInt (playerCar.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().CurrentSpeed);
        speedBox.GetComponent<Text>().text = "" + speed; //converts milliseconds to string and displays it on the ui
    }
}
