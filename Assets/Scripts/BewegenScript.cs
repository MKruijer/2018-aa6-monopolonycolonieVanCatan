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
            if (PlayerPositionRekenen > 40)
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

        for (int i = DiceRollScript.DiceNumber; i > 0; i--)
            {
            if (player.transform.position.x == 50 && player.transform.position.z > -50)
            {
                var pos = player.transform.position;
                pos.z = pos.z - 10;
                player.transform.position = pos;
            }
            else if (player.transform.position.x > -50 && player.transform.position.z == -50)
            {
                var pos = player.transform.position;
                pos.x = pos.x - 10;
                player.transform.position = pos;
            }
            else if (player.transform.position.x == -50 && player.transform.position.z < 50)
            {
                var pos = player.transform.position;
                pos.z = pos.z + 10;
                player.transform.position = pos;
            }
            else if (player.transform.position.x < 50 && player.transform.position.z == 50)
            {
                var pos = player.transform.position;
                pos.x = pos.x + 10;
                player.transform.position = pos;
            }
        }

        MoveKnopZichtbaarheid.enabled = false;
        MoveTekstZichtbaarheid.enabled = false;
    }
}
