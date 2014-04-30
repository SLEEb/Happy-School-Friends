using UnityEngine;
using System.Collections;

public class HeroMovement : MonoBehaviour {
	// Variables
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
	public string gameOver;

	bool ifLeftIsPressed = false;
	bool ifRightIsPressed = false;
	bool ifUpIsPressed = false;
    bool ifDownIsPressed = false;

	void OnGUI(){ // GUI func, one for Score+Lives and one to present a buff text.
		GUI.color = Color.yellow;
		GUI.Box(new Rect(10,10,200,80), scoreText + livesText); // placement 
	
		GUI.contentColor = Color.red; // color 
		GUI.color = Color.red;
		GUI.contentColor = Color.yellow;
		GUI.Box(new Rect(10,90,215,110), buffText);
		}
	// Use this for initialization
	void Start () {


		lives = 3;
		buffText = " ";
		moveSpeed = 3.2f;
		nme = GameObject.FindGameObjectWithTag ("Enemy1"); // nme is a GameObject with the tag Enemy1
		pwr = GameObject.FindGameObjectWithTag ("PowerUp");// pwr is a GameObject with the tag PowerUp
		}

	// Update is called once per frame
	 void Update () {



	// Movement 
		
		// Left
		if (Input.GetKey(KeyCode.LeftArrow)){
			rigidbody2D.velocity = new Vector2(-moveSpeed,0);
			ifLeftIsPressed = true; // The point of this was to at somepoint to make it more stable, and to avoid multiple keys pressed at once. Goes for the rest of these.
			
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

	IEnumerator OnTriggerEnter2D (Collider2D col){ // IEnumerator because the yield return new WaitForSeconds (6.0f); will return.

		if (col.tag == "Points") { // If colliding with a gameobject tagged Points will increment score with int 1. then destroy Points gameobject
		score += 1; 
		scoreText = "Score: " + score;
		Destroy (col.gameObject);
		}

		if (col.gameObject.tag == "PowerUp") { // if colliding with gameobject tagged PowerUp will provide a text, increast the variable moveSpeed; and set the bool immortal = true
		
			buffText = "6 sec boost to kill enemies!\r\nI'TS ALREADY STARTED!!\r\nPress any directional key to use >.<";
			moveSpeed = 10.0f;
			immortal = true;
	
			yield return new WaitForSeconds (6.0f); // this will wait 6 seconds and then it will destroy the PowerUp gameobject, set the bool immortal = false;
			Destroy(col.gameObject);				// then it will reset the moveSpeed variable to 3.2. and reset the buffText
			immortal = false;
			moveSpeed = 3.2f;
			buffText = "";
			}
	
		if (col.gameObject.tag == "Enemy1" && lives >= 1 && immortal != true) { // if colliding with gameobject tagged Enemy1 and lives being bigger or equal to 1
			lives -= 1;															// and the bool immortal is not true it will deduct 1 int from lives;			
			livesText = "Lives: " + lives; 
		} 
		else if (col.gameObject.tag == "Enemy1" && lives == 0) { // if colliding with gameobject tagged Enemy1 and lives = 0 it will destroy the hero
		
			Destroy(gameObject);
		}
		if (col.gameObject.tag == "Enemy1" && immortal == true) { // if colliding with gameobject tagged Enemy1 and the bool immortal is true 
			lives += 0;											  //it will increment with 0, meaning it will stay the same.		
			livesText = "Lives: " + lives; 
		}


		}



	}




