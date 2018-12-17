using UnityEngine;
using UnityEngine.UI;

public class DiceRollScript : MonoBehaviour
{
    public static int DiceNumber = 0;
    public Image MoveKnopZichtbaarheid;
    public Text MoveTekstZichtbaarheid;
    public Image DiceKnopZichtbaarheid;
    public Text DiceTekstZichtbaarheid;
    public Text DiceRollNumberDisplay;
    public static int CanRollDice = 0;

    public void Start()
    {
        DiceRollNumberDisplay.text = "";
        MoveKnopZichtbaarheid.enabled = false;
        MoveTekstZichtbaarheid.enabled = false;
    }

    public void DiceRoll()
    {
        if (CanRollDice == 0)
        {
            //DiceNumber = Random.Range(2, 12);
            DiceNumber = 1;
            DiceRollNumberDisplay.text = "You rolled: " + DiceNumber + "!";
            MoveKnopZichtbaarheid.enabled = true;
            MoveTekstZichtbaarheid.enabled = true;
            DiceKnopZichtbaarheid.enabled = false;
            DiceTekstZichtbaarheid.enabled = false;
            CanRollDice++;
        }
    }
}
