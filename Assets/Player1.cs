using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player1 : MonoBehaviour {

	public static int DiceNumber = 0;
	public static int EndTurn = 0;
	public float PlayerPositionId = 0;
	public float Geld = 200;
	public static int test =5;

	

	public void DiceRoll()
	{
		DiceNumber = UnityEngine.Random.Range(2,12);
		print(DiceNumber);

	}

	public void Bewegen()
	{
		//PlayerPositionId = PlayerPositionId + DiceNumber;

		if(PlayerPositionId == 0) 
		{
			var pos = transform.position;
     		pos.x = 4.5f;
			pos.z = -4.5f;
   			transform.position = pos;
			GetMoneyz();
		}
		if(PlayerPositionId == 1) 
		{
			var pos = transform.position;
     		pos.x = 3.5f;
			pos.z = -4.5f;
   			transform.position = pos;
		}
		if(PlayerPositionId == 2) 
		{
			var pos = transform.position;
     		pos.x = 2.5f;
			pos.z = -4.5f;
   			transform.position = pos;
		}
		if(PlayerPositionId == 3) 
		{
			var pos = transform.position;
     		pos.x = 1.5f;
			pos.z = -4.5f;
   			transform.position = pos;
		}
	}

	public void ActionButton()
	{
		if(PlayerPositionId == 1)
		{
			
		}
	}

	public void GetMoneyz()
	{
		Geld = Geld + 200;
	}

}
