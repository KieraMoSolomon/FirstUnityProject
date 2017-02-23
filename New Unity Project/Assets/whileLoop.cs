using UnityEngine;
using System.Collections;

public class whileLoop : MonoBehaviour {
	private int bottlesOfPop = 0;
	public int maxBottles = 10;

	private bool gameOn = true;

	private int minVal = -100;
	private int maxVal = 100;
	private int randomNum;
	private int counter = 0;
	private int secretNum = 77;
	// Use this for initialization
	void Start () {

		while (randomNum != secretNum) {
			randomNum = Random.Range (minVal, maxVal);
			if (randomNum > secretNum) {
				maxVal = randomNum;
			} else if (randomNum < 0) {
				minVal = randomNum;
			}

			counter++;
			if (randomNum != secretNum) {
				print ("Attempt " + counter + ": secret number is not: " + randomNum);
			}
			else {
				print ("Attempt " + counter + ": secret number is: " + randomNum);
			}
			//if (maxVal == 1 && minVal == -1) {
				//break;
				//this has a condition that it needs to meet before breaking
			//}
			//break; this would stop it after the first run through so we need a condition not a break
		}




		/*while(gameOn){
			print (bottlesOfPop + " bottles of Pop on the wall.");
			bottlesOfPop++;
			if (bottlesOfPop == maxBottles) {
				break;
				//terrminates the loop without changing the value of the variable
			}
		}






		while (bottlesOfPop < maxBottles) {
			if (bottlesOfPop % 2 == 0) {
				print (bottlesOfPop + " bottles of Pop on the wall.");
			}

			bottlesOfPop = bottlesOfPop + 2;
		}
		print ("All done");
*/
	}
}
