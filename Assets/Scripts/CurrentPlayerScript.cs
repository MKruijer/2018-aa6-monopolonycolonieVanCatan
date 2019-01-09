using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentPlayerScript : MonoBehaviour {

    public static string Player1 = "Player1";
    public static string Player2 = "Player2";
    public static string Player3 = "Player3";
    public static string Player4 = "Player4";
    public static string Winner = "";
    public static int CurrentPlayer = 1;
    public static int MaxPlayers = 2;
    public Text CurrentPlayerDisplay;
    public Image DiceKnopZichtbaarheid;
    public Text DiceTekstZichtbaarheid;
    public Image ActionKnopZichtbaarheid;
    public Text ActionTekstZichtbaarheid;
    public static string CurrentPlayerName = Player1;
    public bool GameOver = false;
    public Text DiceRollNumberDisplay;
    public Image ExitKnop;
    public Text ExitText;


    void Update()
    {
        if(GameOver == false)
        {
            ExitKnop.enabled = false;
            ExitText.enabled = false;
        }
        CurrentPlayerDisplay.text = CurrentPlayerName+" is now!";
        if(Player1Script.Player1Geld < 0)
        {
            GameOver = true;
            Winner = Player2;

        }
        if (Player2Script.Player2Geld < 0)
        {
            GameOver = true;
            Winner = Player1;
        }

        if(GameOver == true)
        {

            Destroy(GameObject.Find("Canvas/SwitchPlayerButton"));
            Destroy(GameObject.Find("Canvas/RollDice"));
            Destroy(GameObject.Find("Canvas/Move Button"));
            Destroy(GameObject.Find("Canvas/CurrentPlayerText"));
            Destroy(GameObject.Find("Canvas/ActionButton"));
            Destroy(GameObject.Find("Canvas/MoneyDisplay"));
            Destroy(GameObject.Find("Canvas/Straatkosten"));

            DiceRollNumberDisplay.text = Winner+" has won! Press esc to quit.";
            ExitKnop.enabled = true;
            ExitText.enabled = true;
        }
    }

    public void SwitchPlayer()
    {
        BewegenScript.PlayerPositionRekenen = -1;
        DiceRollScript.CanRollDice = 0;
        DiceKnopZichtbaarheid.enabled = true;
        DiceTekstZichtbaarheid.enabled = true;
        ActionKnopZichtbaarheid.enabled = true;
        ActionTekstZichtbaarheid.enabled = true;
        if (CurrentPlayer == 1)
        {
            CurrentPlayer++;
            CurrentPlayerName = Player2;
            
        }
        else if (CurrentPlayer == 2)
        {
            CurrentPlayer++;
            CurrentPlayerName = Player3;
        }
        else if (CurrentPlayer == 3)
        {
            CurrentPlayer++;
            CurrentPlayerName = Player4;
        }
        else if (CurrentPlayer == 4)
        {
            CurrentPlayer++;
        }
        if (CurrentPlayer > MaxPlayers)
        {
            CurrentPlayer = 1;
            CurrentPlayerName = Player1;
        }
    }
}
