using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
	public GameObject hero;



 
	// Use this for initialization
	void Start () {
		hero = GameObject.FindGameObjectWithTag ("Hero"); // hero is set to the tag of an GameObject
	
		}
	
	// Update is called once per frame
	void Update () {

		}

	void OnTriggerEnter2D (Collider2D trigger){ // Trigger function, checks if Enemies (the script is attached to the prefabs called EnemyCaucasian, EnemyBlackalictios, EnemyChinese, EnemyGinger 
		if (trigger.gameObject.tag == "Hero") { // If they collide this will Destroy the Enemy
			Destroy(gameObject);
				}

		}

}
