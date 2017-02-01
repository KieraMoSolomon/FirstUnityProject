using UnityEngine;
using System.Collections;

public class conve : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/* There are different symbols and things that need to be included for a code to run properly
		 * there is the dot operator that helps to direct the computer to the correct location
		 * sort of like an address. Semi-colons are used to end the statements, they are the indicator
		 * that that part of the code is done. Indenting is very useful to help keep track of what is
		 * happening in the code. It is easier to read where blocks of code begin and end when they are
		 * on the same indentation line.
		 */
		if (Input.GetKeyDown (KeyCode.A)) {
			GetComponent<Renderer> ().material.color = Color.cyan;
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			GetComponent<Renderer> ().material.color = Color.black;
		}
		if (Input.GetKeyDown (KeyCode.G)) {
			GetComponent<Renderer> ().material.color = Color.gray;
		}
		if (Input.GetKeyDown (KeyCode.Y)) {
			GetComponent<Renderer> ().material.color = Color.yellow;
		}
		if (Input.GetKeyDown (KeyCode.U)) {
			GetComponent<Renderer> ().material.color = Color.blue;
		}
		//I didn't know what other examples to do so I just did colors again... Hope that is okay!
	}
}
