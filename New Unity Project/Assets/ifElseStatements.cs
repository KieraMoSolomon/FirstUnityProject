using UnityEngine;
using System.Collections;

public class ifElseStatements : MonoBehaviour {
	//Else if statements will run in order until it finds the true one and will do what that statement says to.
	//Else statements go at the end of the block of code that you want and will run when the if and else if are false.
	private string day = "Wednesday";

	// Use this for initialization
	void Start () {
		if (day == "Sunday") {
			print ("Today is Sunday");
		} else if (day == "Monday") {
			print ("Today is Monday");
		} else if (day == "Tuesday") {
			print ("Today is Tuesday");
		} else if (day == "Wednesday") {
			print ("Today is Wednesday");
		} else if (day == "Thursday") {
			print ("Today is Thursday");
		} else if (day == "Friday") {
			print ("Today is Friday");
		} else if (day == "Saturday") {
			print ("Today is Saturday");
		} else {
			print ("Wow there must be a new day");
		}
	}
}
