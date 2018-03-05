using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float timeOnClock;
    public Text timeDisplay;
    bool runTimer;

	// Use this for initialization
	void Start ()
    {
        timeOnClock = 0;
        runTimer = true;
	}

    void stopTimer()
    {
        runTimer = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(runTimer)
        {
            timeOnClock += Time.deltaTime;
            timeDisplay.text = timeOnClock.ToString().Substring(0, 5);
        }
	}
}
