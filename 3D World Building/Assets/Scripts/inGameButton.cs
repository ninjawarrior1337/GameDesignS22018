using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class inGameButton : MonoBehaviour
{
    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("e"))
        {
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo) && hitInfo.transform.gameObject.CompareTag("Button"))
            {
                anim.SetTrigger("press");
                openOrClose();
            }
            else
            {
                
            }
        }
    }

    void openOrClose()
    {
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("x-ha-access", "tyler321");
        headers.Add("Content-Type", "application/json");

        byte[] postData = System.Text.Encoding.UTF8.GetBytes("{\"entity_id\": \"cover.garage_door\"}");

        WWW www = new WWW("https://treelarhome.duckdns.org/api/services/cover/stop_cover", postData, headers);

        StartCoroutine(WaitForRequest(www));
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;
        if (www.error == null)
        {
            //Print server response
            Debug.Log(www.text);
        }
        else
        {
            //Something goes wrong, print the error response
            Debug.Log(www.error);
        }
    }
}