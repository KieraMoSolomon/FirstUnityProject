using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {
	private float A = 3.0f;
	private int B = 3;
	private string name = "Hope";
	/*
	 * ==
	 * !=
	 * <
	 * >
	 * >=
	 * <=
	 */
	// Use this for initialization
	void Start () {
		if (name != "Austin") {
			print (name);
		}
		if (A == B){
			print ("A is equal to B");
		}
		if (A != B) {
			print ("A is not equal to B");
		}
		if (A < B) {
			print ("A is less than B");
		}
		if (A > B) {
			print ("A is greater than B");
		}
		if (A <= B) {
			print ("A is less than/equal to B");
		}
		if (A >= B) {
			print ("A is greater than/equal to B");
		}
	}
}
