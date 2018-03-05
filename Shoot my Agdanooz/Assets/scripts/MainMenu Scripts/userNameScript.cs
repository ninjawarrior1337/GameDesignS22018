using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class userNameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}

    

    public void setUsername(string username)
    {
        PlayerPrefs.SetString("username", username);
        Debug.Log("Username: " + username);
    }

    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
