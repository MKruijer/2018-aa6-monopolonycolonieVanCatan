using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour {

	public Text GeldDisplay;
	
	// Update is called once per frame
	void Update () {
        if (CurrentPlayerScript.CurrentPlayer == 1)
        {
            GeldDisplay.text = "You have " + Player1Script.Player1Geld + " roebels!";
        }
        if (CurrentPlayerScript.CurrentPlayer == 2)
        {
            GeldDisplay.text = "You have " + Player2Script.Player2Geld + " roebels!";
        }
        if (CurrentPlayerScript.CurrentPlayer == 3)
        {
            //GeldDisplay.text = "You have " + Player3.Geld + " roebels!";
        }
        if (CurrentPlayerScript.CurrentPlayer == 4)
        {
           //GeldDisplay.text = "You have " + Player4.Geld + " roebels!";
        }
    }
}
