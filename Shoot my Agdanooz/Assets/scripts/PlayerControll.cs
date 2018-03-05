using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xmin, xmax, zmin, zmax;
}

public class PlayerControll : MonoBehaviour {

    public float speed;
    public float tilt;
    public Boundary boundary;
    public string username;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    private float moveHoriz;
    private float moveVert;

    private void Start()
    {
        username = PlayerPrefs.GetString("username");
    }

    void FixedUpdate()
    {
        if (DeviceType.Handheld == SystemInfo.deviceType)
        {
            moveHoriz = Input.acceleration.x;
            moveVert = Input.acceleration.y;
        }
        else
        {
            moveHoriz = Input.GetAxis("Horizontal");
            moveVert = Input.GetAxis("Vertical");
        }
        
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVert);

        rb.velocity = movement * speed;

        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, boundary.xmin, boundary.xmax), 
            0f,
            Mathf.Clamp(rb.position.z, boundary.zmin, boundary.zmax)
            );

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, 0f);
        //For when it stops throwing errors: rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            AudioSource fireSound = GetComponent<AudioSource>();
            fireSound.Play();
        }
        else if (Input.GetButton("Fire1") && username == "cheat3r" || Input.GetButton("Fire1") && username == "Cheat3r")
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            AudioSource fireSound = GetComponent<AudioSource>();
            fireSound.Play();
        }
    }
}
