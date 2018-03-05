using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    private Rigidbody rb;
    private int count;
    private float moveHorizontal;
    private float moveVertical;

    public float speed;
    public Text countText;
    public Text winText;
    public GameObject timer;

    void Start()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            Screen.orientation = ScreenOrientation.LandscapeRight;
        }
        rb = GetComponent<Rigidbody>();
        count = 0;
        updateCountText();
        winText.text = null;
    }

    void Update()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            if (Input.GetKey("escape"))
                Application.Quit();
        }
        
        
    }

    void FixedUpdate ()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
        }
        else
        {
            moveHorizontal = Input.acceleration.x;
            moveVertical = Input.acceleration.y;
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            count = count+=1;
            updateCountText();
        }
    }

    void updateCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 13)
        {
            winText.text = "You Win!";
            timer.SendMessage("stopTimer");
        }
    }

    void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
