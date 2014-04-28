using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
	public GameObject hero;


	// Use this for initialization
	void Start () {
		hero = GameObject.FindGameObjectWithTag ("Hero");
		}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D trigger){
		if (trigger.gameObject.tag == "Hero") {
			Destroy(hero);
				}

		}
}
