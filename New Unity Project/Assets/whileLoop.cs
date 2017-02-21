using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {
	private int bottlesOfPop = 0;
	public int maxBottles = 10;

	private bool gameOn = true;
	// Use this for initialization
	void Start () {
		while(gameOn){
			print (bottlesOfPop + " bottles of Pop on the wall.");
			bottlesOfPop++;
			if (bottlesOfPop == maxBottles) {
				gameOn = false;
			}
		}






		/*while (bottlesOfPop < maxBottles) {
			if (bottlesOfPop % 2 == 0) {
				print (bottlesOfPop + " bottles of Pop on the wall.");
			}

			bottlesOfPop = bottlesOfPop + 2;
		}
		print ("All done");
*/
	}
}
