using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class listHomework : MonoBehaviour {
	private int i = 0;
	public string animal;
	public List<string> zooRoster = new List<string>();
	/*Lists are like arrays that don't have boundaries or set numbers to them.
	 * They can add as many elements to them as you need and you don't have to define
	 * a specific number to them. They need System.Collections.Generic in order to be able to run
	 * them properly. If you tried to add in a 4th element with an array set to a number of 3, it
	 * would spit back an error. However, if you have a list you can add in more than just 3 elements
	 * to that list if you realize that you need more than you originally thought.

	*/
	// Use this for initialization
	void Start () {
		zooRoster.Add ("monkey");
		zooRoster.Add ("elephant");
		zooRoster.Add ("alligator");
		zooRoster.Add ("lion");
	}
	public void AddAnimal()
	{
		if (animal != "") {
			if (zooRoster.Contains (animal) != true) {
				zooRoster.Add (animal);
			}
		}
	}
	public void RemoveAnimal()
	{
		if (animal != "") {
			if (zooRoster.Contains (animal) == true) {
				zooRoster.Remove (animal);
			}
		}
	}
	public void ClearAnimal()
	{
		while (i <= zooRoster.Count) {
			zooRoster [i] = "";
			i++;
		}
	}
	public void PrintAnimal ()
	{
		while (i < zooRoster.Count) {
			print (zooRoster [i]);
			i++;
		}
	}
}
