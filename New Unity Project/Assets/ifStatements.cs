using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {
	private float myCash = 20.75f;
	private int noMoney = 0;
	private string store = "Babies R Us";
	private bool shopping = false;
	private bool work = false;

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
		if (myCash > noMoney){
			print ("Yay! You have money, lets go shopping!");
			shopping = true;
		}
		if (myCash <= noMoney) {
			print ("You are broke go to work.");
			work = true;
		}
		if (shopping == true) {
			print ("Always a good idea to spend money on the child, go to Babies R Us!");
		}
		if (shopping == true) {
			print (myCash + " is how much you can spend");
			myCash = 0;
		}
		if (work == true) {
			print ("Work sucks, at least you get more money.");
			myCash = 50;
		}
		if (myCash < noMoney) {
			print ("You spent more than you had.");
		}
		if (){
		}
		if (){
		}
		if () {
		}
		if () {
		}
	}
}
