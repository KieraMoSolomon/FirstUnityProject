using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {
	public int bottlesOfPop = 0;
	// Use this for initialization
	void Start () {
		while (bottlesOfPop < 10) {
			print (bottlesOfPop + " bottles of Pop on the wall.");
			bottlesOfPop++;
		}
		print ("All done");
	}
}
