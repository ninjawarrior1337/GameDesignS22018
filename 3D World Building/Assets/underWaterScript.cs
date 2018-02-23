using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class underWaterScript : MonoBehaviour
{
    Rigidbody fpsRB;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        fpsRB = other.gameObject.GetComponent<Rigidbody>();

        if (fpsRB != null)
        {
            fpsRB.useGravity = false;
        }
            
    }

    private void OnTriggerExit(Collider other)
    {
        fpsRB = other.gameObject.GetComponent<Rigidbody>();
        
        if (fpsRB != null)
        {
            fpsRB.useGravity = true;
        }
    }
}
