using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour 
{

	public Transform enemyRobot;
	//Reference to a game object that is the finish line
	public Transform finishLine;

	//controls how fast the enemy moves
	public float movementSpeed;

	void Update () 
	{
		//Move the enemy in the x direction by "movementSpeed" each frame
		enemyRobot.Translate(movementSpeed,0,0);

		//Checks the position of the enemy against the position of the finish line
		if(enemyRobot.position.x > finishLine.position.x)
		{
			Application.LoadLevel("LoseScene");
		}
	}
}
