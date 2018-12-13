using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour {

	public Text GeldDIsplay;
	
	// Update is called once per frame
	void Update () {
		GeldDIsplay.text = "You have "+Player1.Geld+" roebels!";
	}
}
