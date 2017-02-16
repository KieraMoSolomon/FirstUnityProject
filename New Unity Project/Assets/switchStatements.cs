using UnityEngine;
using System.Collections;

public class switchStatements : MonoBehaviour {
	private int time = 10;
	private string animal = "alligator";
	private string phrase;
	private bool exist = true;

	// Use this for initialization
	void Start () {
		switch (animal) 
		{
		case "giraffe":
			phrase = "wheezy neighbaaaaaah";
			break;
		case "penguin":
			phrase = "Morgan Freeman";
			break;
		case "lion":
			phrase = "roar";
			break;
		case "fox":
			phrase = "adhflknviehflnsjkh";
			break;
		case "alligator":
			phrase = "would you like some tea with that, sir?";
			break;
		default:
			exist = false;
			break;
		}


		if (exist) {
			print ("A " + animal + " says \"" + phrase + "\".");
		} else {
			print (animal + " does not exist.");
		}







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
