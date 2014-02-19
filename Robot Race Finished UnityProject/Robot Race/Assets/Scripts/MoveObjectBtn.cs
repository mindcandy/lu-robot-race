using UnityEngine;
using System.Collections;

public class MoveObjectBtn : MonoBehaviour 
{
	//Stores a reference to the players robot so we can move it whenever the button is clicked
	public Transform playerRobot;

	//The speed that the robot will move across the stage
	public float movementSpeed = 0.2f;

	void OnMouseDown()
	{
		//Move the player in the x direction by "movementSpeed" each frame
		playerRobot.Translate(movementSpeed,0,0);
	}
}
