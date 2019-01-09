using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StraatKostScript : MonoBehaviour {

	public Text StraatDisplay;
	public static int Straat1Kost = 60;
    	public static int Straat2Kost = 60;
    	public static int Straat3Kost = 100;
	public static int Straat4Kost = 100;
	public static int Straat5Kost = 120;
	public static int Straat6Kost = 120;
	public static int Straat7Kost = 140;
	public static int Straat8Kost = 140;
	public static int Straat9Kost = 160;
	public static int Straat10Kost = 160;
	public static int Straat11Kost = 180;
	public static int Straat12Kost = 180;
	public static int Straat13Kost = 200;
	public static int Straat14Kost = 200;
	public static int Straat15Kost = 220;
	public static int Straat16Kost = 220;
	public static int Straat17Kost = 240;
	public static int Straat18Kost = 240;
	public static int Straat19Kost = 260;
	public static int Straat20Kost = 260;
	public static int Straat21Kost = 280;
	public static int Straat22Kost = 280;
	public static int Straat23Kost = 300;
	public static int Straat24Kost = 300;
	public static int Straat25Kost = 320;
	public static int Straat26Kost = 320;
	public static int Straat27Kost = 350;
	public static int Straat28Kost = 400;
   	public static int EigenaarStraat1 = 0;
   	public static int EigenaarStraat2 = 0;
   	public static int EigenaarStraat3 = 0;
	public static int EigenaarStraat4 = 0;
	public static int EigenaarStraat5 = 0;
	public static int EigenaarStraat6 = 0;
	public static int EigenaarStraat7 = 0;
	public static int EigenaarStraat8 = 0;
	public static int EigenaarStraat9 = 0;
	public static int EigenaarStraat10 = 0;
	public static int EigenaarStraat11 = 0;
	public static int EigenaarStraat12 = 0;
	public static int EigenaarStraat13 = 0;
	public static int EigenaarStraat14 = 0;
	public static int EigenaarStraat15 = 0;
	public static int EigenaarStraat16 = 0;
	public static int EigenaarStraat17 = 0;
	public static int EigenaarStraat18 = 0;
	public static int EigenaarStraat19 = 0;
	public static int EigenaarStraat20 = 0;
	public static int EigenaarStraat21 = 0;
	public static int EigenaarStraat22 = 0;
	public static int EigenaarStraat23 = 0;
	public static int EigenaarStraat24 = 0;
	public static int EigenaarStraat25 = 0;
	public static int EigenaarStraat26 = 0;
	public static int EigenaarStraat27 = 0;
	public static int EigenaarStraat28 = 0;
  	public static int TurnKostenStraat1 = 10;
  	public static int TurnKostenStraat2 = 20;
  	public static int TurnKostenStraat3 = 30;
	public static int TurnKostenStraat4 = 40;
	public static int TurnKostenStraat5 = 40;
	public static int TurnKostenStraat6 = 50;
	public static int TurnKostenStraat7 = 50;
	public static int TurnKostenStraat8 = 60;
	public static int TurnKostenStraat9 = 60;
	public static int TurnKostenStraat10 = 75;
	public static int TurnKostenStraat11 = 75;
	public static int TurnKostenStraat12 = 80;
	public static int TurnKostenStraat13 = 90;
	public static int TurnKostenStraat14 = 100;
	public static int TurnKostenStraat15 = 110;
	public static int TurnKostenStraat16 = 110;
	public static int TurnKostenStraat17 = 120;
	public static int TurnKostenStraat18 = 120;
	public static int TurnKostenStraat19 = 125;
	public static int TurnKostenStraat20 = 130;
	public static int TurnKostenStraat21 = 140;
	public static int TurnKostenStraat22 = 140;
	public static int TurnKostenStraat23 = 150;
	public static int TurnKostenStraat24 = 150;
	public static int TurnKostenStraat25 = 160;
	public static int TurnKostenStraat26 = 160;
	public static int TurnKostenStraat27 = 175;
	public static int TurnKostenStraat28 = 200;

    void Update () {
		if (BewegenScript.PlayerPositionRekenen == 0)
        {
		    StraatDisplay.text = "Have 200 Roebels!";
        }
        //straat 1
        else if (BewegenScript.PlayerPositionRekenen == 1 && EigenaarStraat1 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat1Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 1 && EigenaarStraat1 != 0 && EigenaarStraat1 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat1+" for rent!";
        }
        //pay Wordt algemeen fonds
        else if (BewegenScript.PlayerPositionRekenen == 2)
        {
		    StraatDisplay.text = "Work In Progress";
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
		//Pay for Gulag Upkeep Vakje
        else if (BewegenScript.PlayerPositionRekenen == 4)
        {
		    StraatDisplay.text = "Pay 200 for Gulag upkeep!";
        }
		//Wordt Station
		else if (BewegenScript.PlayerPositionRekenen == 5)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//straat 3
		else if (BewegenScript.PlayerPositionRekenen == 6 && EigenaarStraat3 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat3Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 6 && EigenaarStraat3 != 0 && EigenaarStraat3 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat3+" for rent!";
        }
		//Wordt Kans
		else if (BewegenScript.PlayerPositionRekenen == 7)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//straat 4
		else if (BewegenScript.PlayerPositionRekenen == 8 && EigenaarStraat4 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat4Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 8 && EigenaarStraat4 != 0 && EigenaarStraat4 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat4+" for rent!";
        }
		//straat 5
		else if (BewegenScript.PlayerPositionRekenen == 9 && EigenaarStraat5 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat5Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 9 && EigenaarStraat5 != 0 && EigenaarStraat5 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat5+" for rent!";
        }
		//Wordt Gulag
		else if (BewegenScript.PlayerPositionRekenen == 10)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//straat 6
		else if (BewegenScript.PlayerPositionRekenen == 11 && EigenaarStraat6 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat6Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 11 && EigenaarStraat6 != 0 && EigenaarStraat6 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat6+" for rent!";
        }
		//Wordt Veiling
		else if (BewegenScript.PlayerPositionRekenen == 12)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//straat 7
		else if (BewegenScript.PlayerPositionRekenen == 13 && EigenaarStraat7 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat7Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 13 && EigenaarStraat7 != 0 && EigenaarStraat7 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat7+" for rent!";
        }
		//straat 8
		else if (BewegenScript.PlayerPositionRekenen == 14 && EigenaarStraat8 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat8Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 14 && EigenaarStraat8 != 0 && EigenaarStraat8 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat8+" for rent!";
        }
		//Wordt station
		else if (BewegenScript.PlayerPositionRekenen == 15)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//straat 9
		else if (BewegenScript.PlayerPositionRekenen == 16 && EigenaarStraat9 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat9Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 16 && EigenaarStraat9 != 0 && EigenaarStraat9 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat9+" for rent!";
        }
		//Wordt algemeen fonds
		else if (BewegenScript.PlayerPositionRekenen == 17)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//straat 10
		else if (BewegenScript.PlayerPositionRekenen == 18 && EigenaarStraat10 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat10Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 18 && EigenaarStraat10 != 0 && EigenaarStraat10 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat10+" for rent!";
        }
		//straat 11
		else if (BewegenScript.PlayerPositionRekenen == 19 && EigenaarStraat11 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat11Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 19 && EigenaarStraat11 != 0 && EigenaarStraat11 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat11+" for rent!";
        }
		//Vrij Parkeren
		else if (BewegenScript.PlayerPositionRekenen == 20)
        {
		    StraatDisplay.text = "Free Parking!";
        }
		//straat 12
		else if (BewegenScript.PlayerPositionRekenen == 21 && EigenaarStraat12 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat12Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 21 && EigenaarStraat12 != 0 && EigenaarStraat12 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat12+" for rent!";
        }
		//Wordt Kans
		else if (BewegenScript.PlayerPositionRekenen == 22)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//Straat 13
		else if (BewegenScript.PlayerPositionRekenen == 23 && EigenaarStraat13 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat13Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 23 && EigenaarStraat13 != 0 && EigenaarStraat13 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat13+" for rent!";
        }
		//Straat 14
		else if (BewegenScript.PlayerPositionRekenen == 24 && EigenaarStraat14 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat14Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 24 && EigenaarStraat14 != 0 && EigenaarStraat14 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat14+" for rent!";
        }
		//Wordt Station
		else if (BewegenScript.PlayerPositionRekenen == 25)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//Straat 15
		else if (BewegenScript.PlayerPositionRekenen == 26 && EigenaarStraat15 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat15Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 26 && EigenaarStraat15 != 0 && EigenaarStraat15 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat15+" for rent!";
        }
		//Straat 16
		else if (BewegenScript.PlayerPositionRekenen == 27 && EigenaarStraat16 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat16Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 27 && EigenaarStraat16 != 0 && EigenaarStraat16 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat16+" for rent!";
        }
		//Straat 17
		else if (BewegenScript.PlayerPositionRekenen == 28 && EigenaarStraat17 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat17Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 28 && EigenaarStraat17 != 0 && EigenaarStraat17 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat17+" for rent!";
        }
		//Straat 18
		else if (BewegenScript.PlayerPositionRekenen == 29 && EigenaarStraat18 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat18Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 29 && EigenaarStraat18 != 0 && EigenaarStraat18 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat18+" for rent!";
        }
		//Go To Gulag
		else if (BewegenScript.PlayerPositionRekenen == 30)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//Straat 19
		else if (BewegenScript.PlayerPositionRekenen == 31 && EigenaarStraat19 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat19Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 31 && EigenaarStraat19 != 0 && EigenaarStraat19 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat19+" for rent!";
        }
		//Straat 20
		else if (BewegenScript.PlayerPositionRekenen == 32 && EigenaarStraat20 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat20Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 32 && EigenaarStraat20 != 0 && EigenaarStraat20 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat20+" for rent!";
        }
		//Wordt algemeen fonds
		else if (BewegenScript.PlayerPositionRekenen == 33)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//Straat 21
		else if (BewegenScript.PlayerPositionRekenen == 34 && EigenaarStraat21 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat21Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 34 && EigenaarStraat21 != 0 && EigenaarStraat21 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat21+" for rent!";
        }
		//Wordt Station
		else if (BewegenScript.PlayerPositionRekenen == 35)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//Wordt Kans
		else if (BewegenScript.PlayerPositionRekenen == 36)
        {
		    StraatDisplay.text = "Work In Progress";
        }
		//Straat 22
		else if (BewegenScript.PlayerPositionRekenen == 37 && EigenaarStraat22 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat22Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 37 && EigenaarStraat22 != 0 && EigenaarStraat22 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat22+" for rent!";
        }
		//Sharing Is Caring
		else if (BewegenScript.PlayerPositionRekenen == 38)
        {
		    StraatDisplay.text = "Sharing is caring! Pay 200 Roebels";
        }
		//Straat 23
		else if (BewegenScript.PlayerPositionRekenen == 39 && EigenaarStraat23 == 0)
        {
            StraatDisplay.text = "Deze straat kost: " + Straat23Kost + " om te kopen.";
        }
        else if (BewegenScript.PlayerPositionRekenen == 39 && EigenaarStraat23 != 0 && EigenaarStraat23 != CurrentPlayerScript.CurrentPlayer)
        {
            StraatDisplay.text = "Pay "+TurnKostenStraat23+" for rent!";
        }
		//Blanco
        else
        {
			StraatDisplay.text = "";
		}
	}
}
