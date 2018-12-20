using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StraatKostScript : MonoBehaviour {

	public Text StraatDisplay;
	public static int Straat1Kost = 250;
    public static int Straat2Kost = 100;
    public static int Straat3Kost = 200;
    public static int EigenaarStraat1 = 0;
    public static int EigenaarStraat2 = 0;
    public static int EigenaarStraat3 = 0;
    public static int TurnKostenStraat1 = 10;
    public static int TurnKostenStraat2 = 25;
    public static int TurnKostenStraat3 = 50;

    void Update () {
        //straat 1
        if (BewegenScript.PlayerPositionRekenen == 1 && EigenaarStraat1 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat1Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 1 && EigenaarStraat1 != 0 && EigenaarStraat1 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat1+" for rent!";
        }
        //pay for gulag vakje
        else if (BewegenScript.PlayerPositionRekenen == 2)
        {
		    StraatDisplay.text = "Pay 200 for Gulag upkeep!";
        }
        //straat 2
        else if (BewegenScript.PlayerPositionRekenen == 3 && EigenaarStraat2 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat2Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 3 && EigenaarStraat2 != 0 && EigenaarStraat2 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat2+" for rent!";
        }
        //blanko
        else
        {
			StraatDisplay.text = "";
		}
	}
}