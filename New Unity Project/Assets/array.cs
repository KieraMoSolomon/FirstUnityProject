using UnityEngine;
using System.Collections;

public class array : MonoBehaviour {
	private string[] adj1 = {"happy", "wonderful", "annoying", "silly", "weird", "crazy"};
	private string[] adj2 = {"green", "lazy", "fat", "hungry", "stupid", "cute", "slimy"};
	private string[] animal = {"monkey", "pidgeon", "lion", "sloth", "duck", "gecko", "llama", "frog", "goat", "pig"};
	private string[] liquid = {"chocolate syrup", "water", "soad", "pudding", "juice", "milk"};
	private string[] adj3 = {"crunchy", "soft", "warm", "freezing", "purple"};
	private string[] song = {"Once Upon a Dream", "Everything is Fine", "Why don't we just dance", "Turn the Beat Around", "Popular", "Satisfied"};
	private string[] noun1 = {"elephant", "buggy", "wagon", "bus", "shopping cart", "car"};
	private string[] adj4 = {"bumpy", "winding", "dirt", "shinny", "clean", "joyful", "small"};
	private string[] place = {"library", "store", "police station", "church", "restuarant", "post office"};
	private string[] food = {"spaghetti", "meatloaf", "roast", "chocolate", "popcorn", "hamburgers", "salad", "mashed potatoes"};
	private string[] verb = {"jumped", "stabbed", "kissed", "shot", "hugged"};
	private string[] adj5 = {"handsome", "ugly", "strange", "creepy"};

	// Use this for initialization
	void Start () {

		print ("Sleeping Beauty was having a very good dream. It was so " + adj1[Random.Range(0, adj1.Length)] + " that she was giggling in her sleep. " +
			"\n A fluffy kitty and a " + adj2[Random.Range(0, adj2.Length)] + " " + animal[Random.Range(0, animal.Length)] + " were surfing on a sea of " + liquid[Random.Range(0, liquid.Length)] + ". They crashed onto the " + adj3[Random.Range(0, adj3.Length)] + " beach and started doing" +
			"\n an upbeat dance to their very favorite song, " + song[Random.Range(0, song.Length)] + ". Then, they drove a pink " + noun1[Random.Range(0, noun1.Length)] + 
			"\n down the " + adj4[Random.Range(0, adj4.Length)] + " road to the " + place[Random.Range(0, place.Length)] + ". They ordered some pizza and " + food[Random.Range(0, food.Length)] + 
			"\n for lunch. Kitty laughed and got " + food[Random.Range(0, food.Length)] + " all over her fur. Suddenly, Sleeping Beauty woke up! She had been " + verb[Random.Range(0, verb.Length)] + 
			"\n by a " + adj5[Random.Range(0, adj5.Length)] + " prince.");
		
	}
}
