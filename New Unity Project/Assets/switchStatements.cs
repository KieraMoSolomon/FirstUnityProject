using UnityEngine;
using System.Collections;

public class switchStatements : MonoBehaviour {
	private int time = 10;
	private string animal = "alligator";
	private string phrase;
	private bool exist = true;
	//enemy attack
	private string enemy = "monster";
	private int health = 100;
	private string phrase2;
	//factory
	private string product = "doll";
	//gardner
	private string season = "summer";
	private string phrase3;
	private bool garden = true;
	//


	// Use this for initialization
	void Start () {
		switch (enemy) {
		case "monster":
			health = 92;
			phrase2 = "lost 8 health";
			break;
		case "zombie":
			health = 95;
			phrase2 = "lost 5 health";
			break;
		case "werewolf":
			health = 80;
			phrase2 = "lost 20 health";
			break;
		default:
			health = 100;
			phrase2 = "no monsters came"
				break;
		}
		if (health <= 100) {
			print (phrase2);
		}

		switch(product){
		case "nintendo":
			print ("We are out of stock of those");
			break;
		case "doll":
			print ("Making more as we speak");
			break;
		default:
			print ("You can make a request for a toy here");
			break;
		}

		switch (season){
		case "Winter":
			phrase3 = "You don't harvest anything";
			break;
		case "Spring":
			phrase3 = "You can plant some vegetables";
			break;
		case "Summer":
			phrase3 = "The tulips look pretty";
			break;
		default:
			phrase3 = "Fall is when everything starts to die";
			break;
		}
		if (garden){
			print (phrase3);
		}

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
