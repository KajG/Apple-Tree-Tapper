using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Upgrade1 : UpgradeMain {
	
	override protected void Start () {
		Button = Button.GetComponent<Button> ();
		Score = Score.GetComponent<ScoreController> ();
		Createapple = Createapple.GetComponent<CreateApple> ();
		Text = Text.GetComponent<Text> ();
		Pricetag = Pricetag.GetComponent<Text> ();
	}
	override public void onClick(){
		if (Score.getScore >= price) { //Wanneer je genoeg hebt om je upgrade te kopen
			print (Score.getScore);
			Score.getScore -= price;
			Createapple.maxAppleCount += increaseApples;
			price *= priceIncrease;
		}
	}
	override protected void Update(){ //kleur Button
		if (Score.getScore >= price) {
			Text.color = Color.green;
		} 
		if(Score.getScore < price){
			Text.color = Color.red;
		}
		Pricetag.text = (price + "$"); // houd de prijs bij
	}
}
