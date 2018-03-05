﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButcherHit : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			anim.SetBool("playerInCollider", true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			anim.SetBool ("playerInCollider", false);
		}
	}
}
