using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour {

    [SerializeField] string sceneName;

    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Menu"))
        {
            SceneManager.LoadScene(sceneName);
        }
       
    }
}
