using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour 
{
	//Stores a reference to the players robot
	public Transform playerRobot;
	//Reference to a game object that is the finish line
	public Transform finishLine;

	void Update () 
	{
		//if the players x position is greater than the finish lines x position, change the scene 
		if(playerRobot.position.x > finishLine.position.x)
		{
			Application.LoadLevel("WinScene");
		}	
	}
}
