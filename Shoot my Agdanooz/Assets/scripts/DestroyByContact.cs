﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject playerExplosion;

    public int scoreValue;
    private GameController gameController;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameControllerObject == null)
        {
            Debug.Log("Can't find game controller object.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
            return;

        Instantiate(explosion, transform.position, transform.rotation);
        if(other.tag == "Player") 
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.gameOverFunc();
        }
            
        if (other.tag != "Player")
            gameController.addScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
       
    }
}
