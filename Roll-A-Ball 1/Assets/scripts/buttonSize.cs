using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSize : MonoBehaviour {

    public GameObject button;

	// Use this for initialization
	void Start () {
        if (SystemInfo.deviceType == DeviceType.Desktop)
            button.transform.localScale = new Vector3(1.5F, 1.5F, 1.5F);
        else
            button.transform.localScale = new Vector3(2f, 2f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
