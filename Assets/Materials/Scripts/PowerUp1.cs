using UnityEngine;
using System.Collections;

public class PowerUp1 : MonoBehaviour {
	
	public GameObject hero;
	public HeroMovement heroScript;
	public string buffText = "6 sec boost to kill enemies!\r\nI'TS ALREADY STARTED!!\r\nPress any directional key to use >.<";



	void Start () {
		hero = GameObject.FindGameObjectWithTag ("Hero");
		heroScript = hero.GetComponent<HeroMovement> ();

	}
	

	// Update is called once per frame
	void Update () {
	}
	

	IEnumerator OnTriggerEnter2D(Collider2D trigger){

		if (trigger.gameObject.tag == "Hero") {
				
			heroScript.moveSpeed = 10.0f;
			Destroy(gameObject);
			//Debug.Log ("YES");
			yield return new WaitForSeconds (6.0f);
			heroScript.moveSpeed = 2.2f;
           // Debug.Log ("NOOOO!");
			}
	}


	}



