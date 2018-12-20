using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BewegenScript : MonoBehaviour {

    public Image MoveKnopZichtbaarheid;
    public Text MoveTekstZichtbaarheid;
    private GameObject player;
    public static int PlayerPositionRekenen;

    public void Bewegen()
    {
        if (CurrentPlayerScript.CurrentPlayer == 1)
        {
            player = GameObject.Find("Player1");
            Player1Script.Player1PositionId = Player1Script.Player1PositionId + DiceRollScript.DiceNumber;
            PlayerPositionRekenen = Player1Script.Player1PositionId;
            if(PlayerPositionRekenen > 40)
            {
                PlayerPositionRekenen = PlayerPositionRekenen - 40;
            }
        }

        if (CurrentPlayerScript.CurrentPlayer == 2)
        {
            player = GameObject.Find("Player2");
            Player2Script.Player2PositionId = Player2Script.Player2PositionId + DiceRollScript.DiceNumber;
            PlayerPositionRekenen = Player2Script.Player2PositionId;
            if (PlayerPositionRekenen > 40)
            {
                PlayerPositionRekenen = PlayerPositionRekenen - 40;
            }
        }


        if(PlayerPositionRekenen == 0)
        {
            var pos = player.transform.position;
            pos.x = 4.5f;
            pos.z = -4.5f;
            player.transform.position = pos;

        }

        if (PlayerPositionRekenen == 1)
        {
            var pos = player.transform.position;
            pos.x = 3.5f;
            pos.z = -4.5f;
            player.transform.position = pos;
        }

        if (PlayerPositionRekenen == 2)
        {
            var pos = player.transform.position;
            pos.x = 2.5f;
            pos.z = -4.5f;
            player.transform.position = pos;
        }

        if (PlayerPositionRekenen == 3)
        {
            var pos = player.transform.position;
            pos.x = 1.5f;
            pos.z = -4.5f;
            player.transform.position = pos;
        }

        if (PlayerPositionRekenen == 4)
        {
            var pos = player.transform.position;
            pos.x = 0.5f;
            pos.z = -4.5f;
            player.transform.position = pos;
        }

        MoveKnopZichtbaarheid.enabled = false;
        MoveTekstZichtbaarheid.enabled = false;
        print(PlayerPositionRekenen);
    }
}
