using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {
	private int bottlesOfPop = 0;
	public int maxBottles = 10;
	// Use this for initialization
	void Start () {
		while (bottlesOfPop < maxBottles) {
			print (bottlesOfPop + " bottles of Pop on the wall.");
			bottlesOfPop++;
		}
		print ("All done");
	}
}
