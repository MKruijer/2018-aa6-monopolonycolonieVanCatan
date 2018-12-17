using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionScript : MonoBehaviour {
    public static int playerGeld = 0;

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
            Vakje1();
        }
        if(BewegenScript.PlayerPositionRekenen == 1)
        {
            Vakje2();
        }
        if(BewegenScript.PlayerPositionRekenen == 2)
        {
            Vakje3();
        }
        if(BewegenScript.PlayerPositionRekenen == 3)
        {
            Vakje4();
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

    }

    public void Vakje1()
    {
        playerGeld = playerGeld + 200;
    }

    public void Vakje2()
    {
        if (StraatKostScript.EigenaarStraat1 == 0)
        {
            playerGeld = playerGeld - StraatKostScript.Straat1Kost;
            StraatKostScript.EigenaarStraat1 = CurrentPlayerScript.CurrentPlayer;
        }
    }

    public void Vakje3()
    {
        if (StraatKostScript.EigenaarStraat2 == 0)
        {
            playerGeld = playerGeld - StraatKostScript.Straat2Kost;
            StraatKostScript.EigenaarStraat2 = CurrentPlayerScript.CurrentPlayer;
        }
    }

    public void Vakje4()
    {
        if (StraatKostScript.EigenaarStraat3 == 0)
        {
            playerGeld = playerGeld - StraatKostScript.Straat3Kost;
            StraatKostScript.EigenaarStraat3 = CurrentPlayerScript.CurrentPlayer;
        }
    }
}
