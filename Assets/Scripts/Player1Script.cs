using UnityEngine;

public class Player1Script : MonoBehaviour
{
	public static int Player1PositionId = 0;
	public static int Player1Geld = 200;


    public void Update()
    {
        if (Player1PositionId > 40)
        {
            Player1PositionId = Player1PositionId - 40;
        }
    }
}
