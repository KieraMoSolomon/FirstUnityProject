using UnityEngine;
using System.Collections;

public class ifElseStatements : MonoBehaviour {
	private float grade;

	// Use this for initialization
	void Start () {
		if (grade > 90) {
			print ("A");
		} 
		else if (grade > 80) {
			print ("B");
		}
		else if (grade > 70) {
			print ("C");
		}

	}
}
