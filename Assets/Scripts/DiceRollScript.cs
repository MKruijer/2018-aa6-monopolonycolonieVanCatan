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
    public static int DiceNumber1 = 0;
    public static int DiceNumber2 = 0;

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
            DiceNumber1 = Random.Range(1, 6);
            DiceNumber2 = Random.Range(1, 6);
            DiceNumber = DiceNumber1 + DiceNumber2;
            //DiceNumber = 1;
            DiceRollNumberDisplay.text = "You rolled: " + DiceNumber + "!";
            MoveKnopZichtbaarheid.enabled = true;
            MoveTekstZichtbaarheid.enabled = true;
            DiceKnopZichtbaarheid.enabled = false;
            DiceTekstZichtbaarheid.enabled = false;
            CanRollDice++;
        }
    }
}
