using UnityEngine;
using System.Collections;

public class PowerUp1 : MonoBehaviour {
	
	public GameObject hero;
	public HeroMovement heroScript;
	public HeroMovement textBuff;
	public string buffText = "6 sec boost to kill enemies!\r\nI'TS ALREADY STARTED!!\r\nPress any directional key to use >.<";
	public string buffTextEmpty = "\r\n";


	void OnGUI(){
		GUI.color = Color.red;
		GUI.Box(new Rect(10,90,215,110), buffTextEmpty);
		
	}
	void Start () {
		hero = GameObject.FindGameObjectWithTag ("Hero");
		heroScript = hero.GetComponent<HeroMovement> ();



	}
	

	// Update is called once per frame
	void Update () {
	}
	

	IEnumerator OnTriggerEnter2D(Collider2D trigger ){

		if (trigger.gameObject.tag == "Hero") {
				
			buffTextEmpty = buffText;
			heroScript.moveSpeed = 10.0f;
			//Debug.Log ("YES");
			yield return new WaitForSeconds (6.0f); 
			buffText = buffTextEmpty  ;
			heroScript.moveSpeed = 2.2f;
			Destroy(gameObject);
           // Debug.Log ("NOOOO!");
			}


	
	}


	}



