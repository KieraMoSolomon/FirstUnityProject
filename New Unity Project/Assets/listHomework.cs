using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class listHomework : MonoBehaviour {
	private int i = 0;
	public string animal;
	public List<string> zooRoster = new List<string>();
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
