using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {
	private int A = 3;
	private int B = 3;

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
