using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {
	private float myCash = 20.75f;
	private int noMoney = 0;
	private int someMoney = 10;
	private string store = "Babies R Us";
	private bool shopping = false;
	private bool work = false;
	private float husbandCash = 200.33f;

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
			work = false;
		}
		if (myCash < noMoney) {
			print ("You spent more than you had.");
		}
		if (myCash >= someMoney){
			print ("You still have enough to spend more.");
		}
		if (store != "Babies R Us"){
			print ("Target is a bad place that you always over spend at, you better go to Walmart...");
		}
		if (husbandCash > myCash) {
			print ("Husband has more money than I do, I should ask him for some.");
		}
		if (husbandCash < myCash) {
			print ("Well if he has less than I do, we are too poor for me to go shopping.");
		}
	}
}
