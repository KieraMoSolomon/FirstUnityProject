using UnityEngine;
using System.Collections;

public class ifElseStatements : MonoBehaviour {
	private bool awake = false;
	// Use this for initialization
	void Start () {
		if (awake == false) {
			print ("WAKE UP!");
		}
		else {
			print ("Go to sleep!");
		}

	}
}
