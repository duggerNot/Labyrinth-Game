using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    //Game Menu "scene"
    //Play button
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    //Exit Button
    public void QuitGame()
    {
        Application.Quit();
    }
}
