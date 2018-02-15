using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {

    public int minCount;
    public int secCount;
    public float milliCount;

    public GameObject minDisplay;
    public GameObject secDisplay;
    public GameObject milliDisplay;


    // Use this for initialization
    void Start () {

        minCount = PlayerPrefs.GetInt("MinSave");
        secCount = PlayerPrefs.GetInt("SecSave");
        milliCount = PlayerPrefs.GetFloat("MilliSave");

        minDisplay.GetComponent<Text>().text = "0" + minCount + ":";
        secDisplay.GetComponent<Text>().text = "" + secCount + ".";
        milliDisplay.GetComponent<Text>().text = "" + milliCount;



    }

    // Update is called once per frame
    void Update () {
		
	}
}
