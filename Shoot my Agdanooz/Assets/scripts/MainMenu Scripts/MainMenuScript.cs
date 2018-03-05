using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public GameObject mainCanvas;
    public GameObject usernameCanvas;

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

    }

    public void startGame()
    {
        mainCanvas.SetActive(false);
        usernameCanvas.SetActive(true);
    }

    public void showOptions()
    {
        //TODO: Hide the startup canvas in replace with options canvas
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
