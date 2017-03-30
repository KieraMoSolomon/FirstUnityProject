using UnityEngine;
using System.Collections;

public class ExtraCreditAssignment : MonoBehaviour {
	public float health1 = 4.6f;
	public float health2 = 10.0f;
	public float health3 = 1.1f;

	private float Mult(float health1, float health2, float health3){
		float temp = health1 * health2 * health3;
		return temp;
	}
	// Use this for initialization
	void Start () {
		float healthPrint = Mult(health1, health2, health3);
		print (healthPrint);
	}
}
