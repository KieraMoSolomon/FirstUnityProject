using UnityEngine;
using System.Collections;

public class variablesAndOperators : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 2.5f;
	private float length = 3f;
	private float width = 4f;
	private float baseOfTriangle = 2f;
	private float height = 2f;

	// Use this for initialization
	void Start () {
		//find the diameter of a circle
		float diameter = 2 * radius;
		print ("The diameter of a circle with radius " + radius + " is " + diameter);
		float circum = diameter * pi;
		print ("The circumference of a circle with radius " + radius + " is " + circum);
		float areaOfCircle = pi * radius * radius;
		print ("The area of a circle with the radius " + radius + " is " + areaOfCircle);
		float volumeOfCircle = (4 / 3) * pi * (radius * radius * radius);
		print ("The volume of a circle withe the radius " + radius + " is " + volumeOfCircle);
		float perimeterOfRectangle = 2 * length + 2 * width;
		print ("The perimeter of a rectangle with the length of " + length + " and the width of " + width + " is " + perimeterOfRectangle);
		float areaOfRectangle = length * width;
		print ("The area of a rectangle with the length of " + length + " and the width of " + width + " is " + areaOfRectangle);
		float areaOfTriangle = baseOfTriangle * height / 2;
		print ("The area of a triangle with the base of " + baseOfTriangle + " and the height of " + height + " is " + areaOfTriangle);

	}
}
