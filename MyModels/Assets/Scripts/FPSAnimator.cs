using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAnimator : MonoBehaviour {

	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		animator.SetBool("Walking", Input.GetKey(KeyCode.W));
		animator.SetBool("Backwards", Input.GetKey(KeyCode.S));
		animator.SetBool("Running", Input.GetKey(KeyCode.LeftShift));
	}
}
