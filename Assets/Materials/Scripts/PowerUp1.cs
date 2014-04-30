using UnityEngine;
using System.Collections;

public class PowerUp1 : MonoBehaviour {
	
	public GameObject hero;




	void Start () {
		hero = GameObject.FindGameObjectWithTag ("Hero");
	
		}
	

	// Update is called once per frame
	void Update () {
	}
	

	/*void OnTriggerEnter2D(Collider2D trigger ){

		if (trigger.gameObject.tag == "Hero") {
				
		
			Destroy(gameObject);
         
			}

		}*/


	}



