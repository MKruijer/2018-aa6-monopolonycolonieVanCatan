using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StraatKostScript : MonoBehaviour {

	public Text StraatDisplay;
	public static int Straat1Kost = 50;
	public static int Straat1Gekocht = 0;
	
	// Update is called once per frame
	void Update () {
		if(Straat1Gekocht == 0){
		StraatDisplay.text = ""+Straat1Kost;
		}
		else {
			StraatDisplay.text = "";
		}
	}
}
