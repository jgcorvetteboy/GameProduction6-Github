using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public GameObject countDown;
    public AudioSource getReady;
    public AudioSource goAudio;
    public GameObject lapTimer;
    public GameObject carControls;

    public AudioSource levelMusic;

    // Use this for initialization
    void Start () {
        StartCoroutine(CountStart());	
	}
	

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<Text>().text = "3";
        getReady.Play();
        countDown.SetActive(true);
        //
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "2";
        getReady.Play();
        countDown.SetActive(true);
        //
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "1";
        getReady.Play();
        countDown.SetActive(true);
        //
        yield return new WaitForSeconds(1);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "GO";
        goAudio.Play();
        levelMusic.Play();
        countDown.SetActive(true);
        lapTimer.SetActive(true);
        carControls.SetActive(true);


    }



}
