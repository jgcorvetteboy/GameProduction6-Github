using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class MyBrakeLights : MonoBehaviour
    {

        public CarController car; // reference to the car controller, must be dragged in inspector

        public GameObject brakeLight;


        private void Start()
        {
            //brakeLight = GetComponent<GameObject>();
            brakeLight.SetActive(false);
        }


        private void Update()
        {
            // enable the Renderer when the car is braking, disable it otherwise.
            
            if(car.BrakeInput > 0f)
            {
                brakeLight.SetActive(true);
            }
            else
            {
                brakeLight.SetActive(false);
            }
        }

    }
}
