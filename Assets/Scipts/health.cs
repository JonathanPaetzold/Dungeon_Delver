using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour {


	public Player player; 
	public Text hp;
	public Text enemy;

	// Use this for initialization
	void Start () {
		hp.text = "";
		enemy.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		updateText ();
	}

	void updateText () {
		hp.text = "Health:" + player.currStamina.ToString() + "/" + player.maxStamina.ToString ();

		enemy.text = "Health:" + player.enemy.currStamina.ToString () + "/" + player.enemy.maxStamina.ToString ();
		
	}
}
