using UnityEngine;
using System.Collections;

public class ifElseStatements : MonoBehaviour {
	private int time = 15;
	// Use this for initialization
	void Start () {
		if (time >= 18) {
			print ("Go home!");
		} 
		else {
			print ("Back to work slogothor!");
		}

	}
}
