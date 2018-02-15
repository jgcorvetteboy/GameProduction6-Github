using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelScript : MonoBehaviour {

    [SerializeField] string sceneName;

    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
