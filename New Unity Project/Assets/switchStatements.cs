using UnityEngine;
using System.Collections;

public class switchStatements : MonoBehaviour {
	private int time = 10;
	// Use this for initialization
	void Start () {
		//create a switch statement for time of day
		switch (time) {
		case 9:
			print ("Good morning");
			print ("It's pleasantly brisk outside.");
			break;
		case 12:
			print ("Lunch time!");
			break;
		case 18:
			print ("Time to go home");
			break;
		default:
			print ("Get back to work!");
			break;
		}
	}
}
