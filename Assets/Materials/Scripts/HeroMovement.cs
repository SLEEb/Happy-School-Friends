﻿using UnityEngine;
using System.Collections;

public class HeroMovement : MonoBehaviour {

	public float moveSpeed;
	public float msBuff;

	 bool ifLeftIsPressed = false;
	 bool ifRightIsPressed = false;
	 bool ifUpIsPressed = false;
     bool ifDownIsPressed = false;

	// Use this for initialization
	void Start () {
		moveSpeed = 2.2f;

		}

	// Update is called once per frame
	 void Update () {

	
	// Movement
		
		// Left
		if (Input.GetKey(KeyCode.LeftArrow)){
			rigidbody2D.velocity = new Vector2(-moveSpeed,0);
			ifLeftIsPressed = true;
			
		}
		else if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			ifLeftIsPressed = false;
		}
		
		// Right
		if (Input.GetKey(KeyCode.RightArrow)){
			rigidbody2D.velocity = new Vector2(moveSpeed,0);
			ifRightIsPressed = true;
			
		}
		else if (Input.GetKeyUp (KeyCode.RightArrow)) {
			ifRightIsPressed = false;
		}
		
		// Up
		if (Input.GetKey(KeyCode.UpArrow)){
			rigidbody2D.velocity = new Vector2(0,moveSpeed);
			ifUpIsPressed = true;
		}
		
		else if (Input.GetKeyUp (KeyCode.UpArrow)) {
			ifUpIsPressed = false;
		}
		
		if (Input.GetKey(KeyCode.DownArrow)){
			rigidbody2D.velocity = new Vector2(0,-moveSpeed);
			ifDownIsPressed = true;
		}
		else if (Input.GetKeyUp (KeyCode.DownArrow)) {
			ifDownIsPressed = false;
		}
		//Debug.Log(moveSpeed);


		}


	}



