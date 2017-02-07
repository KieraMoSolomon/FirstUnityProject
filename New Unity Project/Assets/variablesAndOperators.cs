using UnityEngine;
using System.Collections;

public class variablesAndOperators : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 2.5f;

	// Use this for initialization
	void Start () {
		//find the diameter of a circle
		float diameter = 2 * radius;
		print ("The diameter of a circle with radius " + radius + " is " + diameter);
		float circum = diameter * pi;
		print ("The circumference of a circle with radius " + radius + " is " + circum);
		float areaOfCircle = pi * radius * 2;
		print ("The area of a circle with the radius " + radius + " is " + areaOfCircle);
		float volumeOfCircle = (4 / 3) * pi * radius * radius * radius;
		print ("The volume of a circle withe the radius " + radius + " is " + volumeOfCircle);

	}
}
