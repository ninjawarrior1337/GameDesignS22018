using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notPractice : MonoBehaviour 
{
	void Start () {
		//localvariboi
		int score = int.MaxValue;
		string aboom = "Hello, ";

		//Data types are funnnnnnnnnnnnnnnnnnnnnnnnnnnnn
		Debug.Log(aboom + score);
		score = score+5;
		Debug.Log(aboom+score);
		score = score+=5;
		Debug.Log(aboom + score);
		score++;
		Debug.Log(aboom + score);
	}
}
