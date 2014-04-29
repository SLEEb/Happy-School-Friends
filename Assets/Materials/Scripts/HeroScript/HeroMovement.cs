using UnityEngine;
using System.Collections;

public class HeroMovement : MonoBehaviour {

	public float moveSpeed;
	public float msBuff;
	public int score;
	public string scoreText = "Score: 0";
	public GUISkin guiSkin; 
	//public string buffText = "6 sec boost to kill enemies!\r\nI'TS ALREADY STARTED!!\r\nPress any directional key to use >.<";
	//public string buffTextEmpty = "";

	bool ifLeftIsPressed = false;
	bool ifRightIsPressed = false;
	bool ifUpIsPressed = false;
    bool ifDownIsPressed = false;

	void OnGUI(){
		GUI.color = Color.yellow;
		GUI.Box(new Rect(10,10,200,80), scoreText);

		}
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

	void OnTriggerEnter2D (Collider2D col){
		if (col.tag == "Points") { 
		score += 1; 
		scoreText = "Score: " + score;
	
		Destroy (col.gameObject);
		}

		}


	}



