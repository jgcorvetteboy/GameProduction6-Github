using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour {

    public GameObject anyname;
    public GameObject anyname2;
    public GameObject anyname3;
    public GameObject anyname4;

    // Use this for initialization

    void Start () {
        StartCoroutine(delayStart());
        
        
    }

    IEnumerator delayStart()
    {
        yield return new WaitForSeconds(3.5f);
        anyname.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        anyname2.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        anyname3.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        anyname4.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
    }
 
}

