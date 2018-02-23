using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleComponentOnKeypress : MonoBehaviour {

    public List<GameObject> objectArray;
    public KeyCode toggleButton;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(toggleButton))
        {
            foreach(GameObject go in objectArray)
            {
                go.SetActive(!go.activeSelf);
            }
        }
	}
}
