using UnityEngine;
using System.Collections;

public class ExtraCreditAssignment : MonoBehaviour {
	public float health1 = 4.6f;
	public float health2 = 10.0f;
	public float health3 = 1.1f;

	public float Mult(){
		float temp = health1 * health2 * health3;
		return temp;
	}
	// Use this for initialization
	void Start () {


	}
}
