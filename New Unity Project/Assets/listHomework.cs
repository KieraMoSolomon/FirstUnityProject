using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class listHomework : MonoBehaviour {
	public string animal;
	public List<string> zooRoster = new List<string>();
	// Use this for initialization
	void Start () {
		zooRoster.Add ("monkey");
		zooRoster.Add ("elephant");
		zooRoster.Add ("alligator");
	}
	public void AddAnimal()
	{
		if (animal != "") {
			if (zooRoster.Contains (animal) != true) {
				zooRoster.Add (animal);
			}
		}
	}
}
