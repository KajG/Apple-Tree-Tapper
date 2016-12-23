using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellApples : MonoBehaviour {

	public List<int> applesInBasket;
	public CreateApple Createapple;
	int apple = 1;

	void Start () {
		applesInBasket = new List<int> ();
	}
	
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Apple") {
			applesInBasket.Add (apple);
			print (applesInBasket.Count);
		}
	}
	public void SellAll(){
		for (int i = 0; i < Createapple.maxAppleCount; i++) {
			Destroy (Createapple._apples [0]);
			Createapple._apples.RemoveAt (0);
		}
		for (int i = 0; i < applesInBasket.Count; i++) {
			applesInBasket.RemoveAt (0);
		}
	}
}
