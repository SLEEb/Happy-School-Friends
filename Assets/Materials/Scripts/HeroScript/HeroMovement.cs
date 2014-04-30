using UnityEngine;
using System.Collections;

public class HeroMovement : MonoBehaviour {

	public float moveSpeed;
	public float msBuff;

	public int score;
	public string scoreText = "Score: 0";
	public bool immortal = false;
	public int lives = 3;
	public string livesText = "Lives: 3";

	public string buffText;
	public string buffTextEmpty;

	public GameObject pwr;
	public GameObject nme;

	bool ifLeftIsPressed = false;
	bool ifRightIsPressed = false;
	bool ifUpIsPressed = false;
    bool ifDownIsPressed = false;

	void OnGUI(){
		GUI.color = Color.yellow;
		GUI.Box(new Rect(10,10,200,80), scoreText + livesText);
		GUI.contentColor = Color.red;
		GUI.color = Color.red;
		GUI.contentColor = Color.yellow;
		GUI.Box(new Rect(10,90,215,110), buffText);
		}
	// Use this for initialization
	void Start () {


		lives = 3;
		buffText = " ";
		moveSpeed = 3.2f;
		nme = GameObject.FindGameObjectWithTag ("Enemy1");
		pwr = GameObject.FindGameObjectWithTag ("PowerUp");
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
	

		}

	IEnumerator OnTriggerEnter2D (Collider2D col){

		if (col.tag == "Points") { 
		score += 1; 
		scoreText = "Score: " + score;
		Destroy (col.gameObject);
		}

		if (col.gameObject.tag == "PowerUp") {
		
			buffText = "6 sec boost to kill enemies!\r\nI'TS ALREADY STARTED!!\r\nPress any directional key to use >.<";
			moveSpeed = 10.0f;
			immortal = true;
	
			yield return new WaitForSeconds (6.0f);
			Destroy(col.gameObject);
			immortal = false;
			moveSpeed = 3.2f;
			buffText = "";
			}
	
		if (col.gameObject.tag == "Enemy1" && lives >= 1 && immortal != true) {
			lives -= 1;
			livesText = "Lives: " + lives; 
		} 
		else if (col.gameObject.tag == "Enemy1" && lives == 0) {
			Destroy(gameObject);
		}
		if (col.gameObject.tag == "Enemy1" && immortal == true) {
			lives += 0;
			livesText = "Lives: " + lives; 
		}


		}



	}




