using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StraatKostScript : MonoBehaviour {

	public Text StraatDisplay;
	public static int Straat1Kost = 50;
    public static int Straat2Kost = 100;
    public static int Straat3Kost = 200;
    public static int EigenaarStraat1 = 0;
    public static int EigenaarStraat2 = 0;
    public static int EigenaarStraat3 = 0;

    void Update () {
        if (BewegenScript.PlayerPositionRekenen == 1 && EigenaarStraat1 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat1Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 2 && EigenaarStraat2 == 0)
        {
		    StraatDisplay.text = "Deze straat kost: " + Straat2Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 3 && EigenaarStraat3 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat3Kost + " om te kopen.";
        }
        else
        {
			StraatDisplay.text = "";
		}
	}
}
