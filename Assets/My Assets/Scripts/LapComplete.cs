using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

    public GameObject lapCompleteTrig;
    public GameObject nextLapTrig;

    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject milliDisplay;

    public GameObject lapTimeBox;

    public GameObject lapCounter;
    public int lapsDone;

    public float rawTime;

    public GameObject raceFinish;

    void Start()
    {
        lapsDone = 1;
        lapCounter.GetComponent<Text>().text = "" + lapsDone;
    }
        
    
    void Update()
    {
        lapCounter.GetComponent<Text>().text = "" + lapsDone;

        if (lapsDone == 4)
        {
            raceFinish.SetActive(true);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lapsDone++;
            rawTime = PlayerPrefs.GetFloat("rawTime");

            if (LapTimeManager.rawTime <= rawTime)
            {
                //seconds
                if (LapTimeManager.secondCount <= 9)
                {
                    secondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ".";
                }
                else
                {
                    secondDisplay.GetComponent<Text>().text = LapTimeManager.secondCount + ".";
                }

                //minute 
                if (LapTimeManager.minuteCount <= 9)
                {
                    minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ":";
                }
                else
                {
                    minuteDisplay.GetComponent<Text>().text = LapTimeManager.minuteCount + ":";
                }

                //milliseconds
                milliDisplay.GetComponent<Text>().text = "" + LapTimeManager.milliCount;
            }


            PlayerPrefs.SetInt("MinSave", LapTimeManager.minuteCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.secondCount);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManager.milliCount);
            PlayerPrefs.SetFloat("rawTime", LapTimeManager.rawTime);


            //reset current laptime
            LapTimeManager.minuteCount = 0;
            LapTimeManager.secondCount = 0;
            LapTimeManager.milliCount = 0;
            LapTimeManager.rawTime = 0;
            lapCounter.GetComponent<Text>().text = "" + lapsDone;

            nextLapTrig.SetActive(true);
            lapCompleteTrig.SetActive(false);

        }
    }

}
