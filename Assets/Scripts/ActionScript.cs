using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionScript : MonoBehaviour {
    public static int playerGeld = 0;
    public Image ActionKnopZichtbaarheid;
    public Text ActionTekstZichtbaarheid;

    public void ActionScriptUitvoeren()
    {

        //begin of turn adjustment/loading properties
        if (CurrentPlayerScript.CurrentPlayer == 1)
        {
            playerGeld = Player1Script.Player1Geld;
        }
        else if (CurrentPlayerScript.CurrentPlayer == 2)
        {
            playerGeld = Player2Script.Player2Geld;
        }


        //changing stuff
        if (BewegenScript.PlayerPositionRekenen == 0)
        {
            Vakje0();
        }
        if(BewegenScript.PlayerPositionRekenen == 1)
        {
            Vakje1();
        }
        if(BewegenScript.PlayerPositionRekenen == 2)
        {
            Vakje2();
        }
        if(BewegenScript.PlayerPositionRekenen == 3)
        {
            Vakje3();
        }
		if(BewegenScript.PlayerPositionRekenen == 4)
        {
            Vakje4();
        }
		if(BewegenScript.PlayerPositionRekenen == 5)
        {
            Vakje5();
        }
		if(BewegenScript.PlayerPositionRekenen == 6)
        {
            Vakje6();
        }
		if(BewegenScript.PlayerPositionRekenen == 7)
        {
            Vakje7();
        }
		if(BewegenScript.PlayerPositionRekenen == 8)
        {
            Vakje8();
        }
		if(BewegenScript.PlayerPositionRekenen == 9)
        {
            Vakje9();
        }
        if(BewegenScript.PlayerPositionRekenen == 10)
        {
            Vakje10();
        }
         if(BewegenScript.PlayerPositionRekenen == 11)
        {
            Vakje11();
        }
         if(BewegenScript.PlayerPositionRekenen == 12)
        {
            Vakje12();
        }
         if(BewegenScript.PlayerPositionRekenen == 13)
        {
            Vakje13();
        }
         if(BewegenScript.PlayerPositionRekenen == 14)
        {
            Vakje14();
        }
         if(BewegenScript.PlayerPositionRekenen == 15)
        {
            Vakje15();
        }
         if(BewegenScript.PlayerPositionRekenen == 16)
        {
            Vakje16();
        }
         if(BewegenScript.PlayerPositionRekenen ==17)
        {
            Vakje17();
        }
         if(BewegenScript.PlayerPositionRekenen == 18)
        {
            Vakje18();
        }
         if(BewegenScript.PlayerPositionRekenen == 19)
        {
            Vakje19();
        }
         if(BewegenScript.PlayerPositionRekenen == 20)
        {
            Vakje20();
        }
         if(BewegenScript.PlayerPositionRekenen == 21)
        {
            Vakje21();
        }
         if(BewegenScript.PlayerPositionRekenen == 22)
        {
            Vakje22();
        }
         if(BewegenScript.PlayerPositionRekenen == 23)
        {
            Vakje23();
        }
         if(BewegenScript.PlayerPositionRekenen == 24)
        {
            Vakje24();
        }
         if(BewegenScript.PlayerPositionRekenen == 25)
        {
            Vakje25();
        }
         if(BewegenScript.PlayerPositionRekenen == 26)
        {
            Vakje26();
        }
         if(BewegenScript.PlayerPositionRekenen == 27)
        {
            Vakje27();
        }
         if(BewegenScript.PlayerPositionRekenen == 28)
        {
            Vakje28();
        }
         if(BewegenScript.PlayerPositionRekenen == 29)
        {
            Vakje29();
        }
         if(BewegenScript.PlayerPositionRekenen == 30)
        {
            Vakje30();
        }
         if(BewegenScript.PlayerPositionRekenen == 31)
        {
            Vakje31();
        }
         if(BewegenScript.PlayerPositionRekenen == 32)
        {
            Vakje32();
        }
         if(BewegenScript.PlayerPositionRekenen == 33)
        {
            Vakje33();
        }
         if(BewegenScript.PlayerPositionRekenen == 34)
        {
            Vakje34();
        }
         if(BewegenScript.PlayerPositionRekenen == 35)
        {
            Vakje35();
        }
         if(BewegenScript.PlayerPositionRekenen == 36)
        {
            Vakje36();
        }
         if(BewegenScript.PlayerPositionRekenen == 37)
        {
            Vakje37();
        }
         if(BewegenScript.PlayerPositionRekenen == 38)
        {
            Vakje38();
        }
         if(BewegenScript.PlayerPositionRekenen == 39)
        {
            Vakje39();
        }




        //end of turn adjustment
        if (CurrentPlayerScript.CurrentPlayer == 1)
        {
            Player1Script.Player1Geld = playerGeld;
        }
        else if (CurrentPlayerScript.CurrentPlayer == 2)
        {
            Player2Script.Player2Geld = playerGeld;
        }
        ActionKnopZichtbaarheid.enabled = false;
        ActionTekstZichtbaarheid.enabled = false;

    }

    public void Vakje0()
    {
        playerGeld = playerGeld + 200;
    }

    public void Vakje1()
    {
        if (StraatKostScript.EigenaarStraat1 == 0 && playerGeld >= StraatKostScript.Straat1Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat1Kost;
            StraatKostScript.EigenaarStraat1 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat1 != 0 && StraatKostScript.EigenaarStraat1 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat1;
            
        }
    }

    public void Vakje2()
    {
        playerGeld = playerGeld - 100;
        //wordt algemeen fonds
    }

    public void Vakje3()
    {
        if (StraatKostScript.EigenaarStraat2 == 0 && playerGeld >= StraatKostScript.Straat2Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat2Kost;
            StraatKostScript.EigenaarStraat2 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat2 != 0 && StraatKostScript.EigenaarStraat2 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat2;
        }
    }
	
	public void Vakje4()
	{
		playerGeld = playerGeld - 100;
	}
	
	public void Vakje5()
	{
		if (StraatKostScript.EigenaarStraat3 == 0 && playerGeld >= StraatKostScript.Straat3Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat3Kost;
            StraatKostScript.EigenaarStraat3 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat3 != 0 && StraatKostScript.EigenaarStraat3 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat3;
            //wordt station functie
        }
	}
	
	public void Vakje6()
	{
		if (StraatKostScript.EigenaarStraat4 == 0 && playerGeld >= StraatKostScript.Straat4Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat4Kost;
            StraatKostScript.EigenaarStraat4 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat4 != 0 && StraatKostScript.EigenaarStraat4 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat4;
            
        }
	}
	
	public void Vakje7()
	{
		playerGeld = playerGeld + 100;
        //wordt Kans 
	}
	
    public void Vakje8()
    {
        if (StraatKostScript.EigenaarStraat5 == 0 && playerGeld >= StraatKostScript.Straat5Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat5Kost;
            StraatKostScript.EigenaarStraat5 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat5 != 0 && StraatKostScript.EigenaarStraat5 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat5;
            
        }
    }

    public void Vakje9()
    {
        if (StraatKostScript.EigenaarStraat6 == 0 && playerGeld >= StraatKostScript.Straat6Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat6Kost;
            StraatKostScript.EigenaarStraat6 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat6 != 0 && StraatKostScript.EigenaarStraat6 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat6;
            
        }
    }

    public void Vakje10()
    {
        playerGeld = playerGeld - 100;
        //wordt Gulag
    }

    public void Vakje11()
    {
         if (StraatKostScript.EigenaarStraat7 == 0 && playerGeld >= StraatKostScript.Straat7Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat7Kost;
            StraatKostScript.EigenaarStraat7 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat7 != 0 && StraatKostScript.EigenaarStraat7 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat7;
    }

    public void Vakje(12)
    {
        playerGeld = playerGeld + 150;
        //wordt veiling
    }

    public void Vakje13()
    {
         if (StraatKostScript.EigenaarStraat8 == 0 && playerGeld >= StraatKostScript.Straat8Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat8Kost;
            StraatKostScript.EigenaarStraat8 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat8 != 0 && StraatKostScript.EigenaarStraat8 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat8;
    }

    public void Vakje14()
    {
         if (StraatKostScript.EigenaarStraat9 == 0 && playerGeld >= StraatKostScript.Straat9Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat9Kost;
            StraatKostScript.EigenaarStraat9 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat9 != 0 && StraatKostScript.EigenaarStraat9 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat9;
    }

    public void Vakje15()
    {
         if (StraatKostScript.EigenaarStraat10 == 0 && playerGeld >= StraatKostScript.Straat10Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat10Kost;
            StraatKostScript.EigenaarStraat10 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat10 != 0 && StraatKostScript.EigenaarStraat10 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat10;
    }

    public void Vakje16()
    {
         if (StraatKostScript.EigenaarStraat11 == 0 && playerGeld >= StraatKostScript.Straat11Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat11Kost;
            StraatKostScript.EigenaarStraat11 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat11 != 0 && StraatKostScript.EigenaarStraat11 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat11;
    }

    public void Vakje17()
    {
        playerGeld = playerGeld - 100;
        //wordt algemeen fonds
    }

    public void Vakje18()
    {
         if (StraatKostScript.EigenaarStraat12 == 0 && playerGeld >= StraatKostScript.Straat12Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat12Kost;
            StraatKostScript.EigenaarStraat12 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat12 != 0 && StraatKostScript.EigenaarStraat12 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat12;
    }

    public void Vakje19()
    {
          if (StraatKostScript.EigenaarStraat13 == 0 && playerGeld >= StraatKostScript.Straat13Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat13Kost;
            StraatKostScript.EigenaarStraat13 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat13 != 0 && StraatKostScript.EigenaarStraat13 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat13;
    }

    public void Vakje20()
    {
        playerGeld = playerGeld + 100;
    }

    public void Vakje21()
    {
          if (StraatKostScript.EigenaarStraat14 == 0 && playerGeld >= StraatKostScript.Straat14Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat14Kost;
            StraatKostScript.EigenaarStraat14 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat14 != 0 && StraatKostScript.EigenaarStraat14 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat14;
    }

    public void Vakje22()
    {
        playerGeld = playerGeld - 100;
        //wordt Kans
    }

    public void Vakje23()
    {
          if (StraatKostScript.EigenaarStraat15 == 0 && playerGeld >= StraatKostScript.Straat15Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat15Kost;
            StraatKostScript.EigenaarStraat15 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat15 != 0 && StraatKostScript.EigenaarStraat15 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat15;
    }

    public void Vakje24()
    {
          if (StraatKostScript.EigenaarStraat16 == 0 && playerGeld >= StraatKostScript.Straat16Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat16Kost;
            StraatKostScript.EigenaarStraat16 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat16 != 0 && StraatKostScript.EigenaarStraat16 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat16;
    }

    public void Vakje25()
    {
          if (StraatKostScript.EigenaarStraat17 == 0 && playerGeld >= StraatKostScript.Straat17Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat17Kost;
            StraatKostScript.EigenaarStraat17 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat17 != 0 && StraatKostScript.EigenaarStraat17 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat17;
            //wordt een station functie
    }

    public void Vakje26()
    {
          if (StraatKostScript.EigenaarStraat18 == 0 && playerGeld >= StraatKostScript.Straat18Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat18Kost;
            StraatKostScript.EigenaarStraat18 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat18 != 0 && StraatKostScript.EigenaarStraat18 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat18;
    }

    public void Vakje27()
    {
          if (StraatKostScript.EigenaarStraat19 == 0 && playerGeld >= StraatKostScript.Straat19Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat19Kost;
            StraatKostScript.EigenaarStraat19 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat19 != 0 && StraatKostScript.EigenaarStraat19 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat19;
    }

    public void Vakje28()
    {
          if (StraatKostScript.EigenaarStraat20 == 0 && playerGeld >= StraatKostScript.Straat20Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat20Kost;
            StraatKostScript.EigenaarStraat20 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat20 != 0 && StraatKostScript.EigenaarStraat20 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat20;
    }

    public void Vakje29()
    {
          if (StraatKostScript.EigenaarStraat21 == 0 && playerGeld >= StraatKostScript.Straat21Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat21Kost;
            StraatKostScript.EigenaarStraat21 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat21 != 0 && StraatKostScript.EigenaarStraat21 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat21;
    }

    public void Vakje30()
    {
        //functie Go To Gulag
    }

    public void Vakje31()
    {
            if (StraatKostScript.EigenaarStraat22 == 0 && playerGeld >= StraatKostScript.Straat22Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat22Kost;
            StraatKostScript.EigenaarStraat22 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat22 != 0 && StraatKostScript.EigenaarStraat22 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat22;
    }

    public void Vakje32()
    {
            if (StraatKostScript.EigenaarStraat23 == 0 && playerGeld >= StraatKostScript.Straat23Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat23Kost;
            StraatKostScript.EigenaarStraat23 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat23 != 0 && StraatKostScript.EigenaarStraat23 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat23;
    }

    public void Vakje33()
    {
        playerGeld = playerGeld - 100;
        //wordt algemeen fonds
    }

    public void Vakje34()
    {
            if (StraatKostScript.EigenaarStraat24 == 0 && playerGeld >= StraatKostScript.Straat24Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat24Kost;
            StraatKostScript.EigenaarStraat24 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat24 != 0 && StraatKostScript.EigenaarStraat24 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat24;
    }

    public void Vakje35()
    {
            if (StraatKostScript.EigenaarStraat25 == 0 && playerGeld >= StraatKostScript.Straat25Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat25Kost;
            StraatKostScript.EigenaarStraat25 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat25 != 0 && StraatKostScript.EigenaarStraat25 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat25;
            //wordt station functie
    }

    public void Vakje36()
    {
        playerGeld = playerGeld - 100;
        //wordt Kans
    }

    public void Vakje37()
    {
            if (StraatKostScript.EigenaarStraat26 == 0 && playerGeld >= StraatKostScript.Straat26Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat26Kost;
            StraatKostScript.EigenaarStraat26 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat26 != 0 && StraatKostScript.EigenaarStraat26 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat26;
    }

    public void Vakje38()
    {
            if (StraatKostScript.EigenaarStraat27 == 0 && playerGeld >= StraatKostScript.Straat27Kost)
        {
            playerGeld = playerGeld - StraatKostScript.Straat27Kost;
            StraatKostScript.EigenaarStraat27 = CurrentPlayerScript.CurrentPlayer;
        }
        else if (StraatKostScript.EigenaarStraat27 != 0 && StraatKostScript.EigenaarStraat27 != CurrentPlayerScript.CurrentPlayer)
        {
            playerGeld = playerGeld - StraatKostScript.TurnKostenStraat27;
    }
}
