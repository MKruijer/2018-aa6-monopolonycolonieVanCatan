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
        playerGeld = playerGeld - 200;
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
}
