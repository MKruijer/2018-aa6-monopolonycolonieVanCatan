using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionScript : MonoBehaviour {
    public int playerGeld = 0;

    public void ActionScriptUitvoeren()
    {
        if (CurrentPlayerScript.CurrentPlayer == 1)
        {
            playerGeld = Player1Script.Player1Geld;
        }
        else if (CurrentPlayerScript.CurrentPlayer == 2)
        {
            playerGeld = Player2Script.Player2Geld;
        }

        if (BewegenScript.PlayerPositionRekenen == 0)
        {
            Vakje1();
        }
        if(BewegenScript.PlayerPositionRekenen == 2)
        {
            Vakje3();
        }

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
    public void Vakje3()
    {
        if (StraatKostScript.EigenaarStraat2 == 0)
        {
            playerGeld = playerGeld - 50;
            StraatKostScript.EigenaarStraat2 = CurrentPlayerScript.CurrentPlayer;
        }
    }
}
