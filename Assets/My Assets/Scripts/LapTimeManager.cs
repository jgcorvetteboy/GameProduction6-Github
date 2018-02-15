using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour {

    public static int minuteCount;
    public static int secondCount;
    public static float milliCount;
    public static string milliDisplay;

    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject milliBox;

    public static float rawTime;

	// Update is called once per frame
	void Update () {

        milliCount += Time.deltaTime * 10;
        rawTime += Time.deltaTime;
        milliDisplay = milliCount.ToString("F0");
        milliBox.GetComponent<Text>().text = "" + milliDisplay; //converts milliseconds to string and displays it on the ui

        if(milliCount >= 10) //sets milliseconds to 0 and increases seconds by 1
        {
            milliCount = 0;
            secondCount++;
        }

        if (secondCount <= 9)// displays seconds depending on whether it is a single digit (<=9) or double digit (>9)
        {
            secondBox.GetComponent<Text>().text = "0" + secondCount + ".";
        }
        else
        {
            secondBox.GetComponent<Text>().text = secondCount + ".";
        }

        if (secondCount >= 60) //increase minite count when seconds equals 60
        {
            secondCount = 0;
            minuteCount++;
        }

        if (minuteCount <= 9)
        {
            minuteBox.GetComponent<Text>().text = "0" + minuteCount + ":";
        }
        else
        {
            minuteBox.GetComponent<Text>().text = minuteCount + ":";
        }


		
	}
}
