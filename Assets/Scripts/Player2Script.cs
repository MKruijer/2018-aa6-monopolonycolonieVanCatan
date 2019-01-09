using UnityEngine;

public class Player2Script : MonoBehaviour
{
    public static int Player2PositionId = 0;
    public static int Player2Geld = 2000;

    public void Update()
    {
        if (Player2PositionId > 40)
        {
            Player2PositionId = Player2PositionId - 40;
        }
    }
}
