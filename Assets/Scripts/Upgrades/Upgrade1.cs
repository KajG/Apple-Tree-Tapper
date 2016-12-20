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
		if (Score.getScore >= price && !bought) { //Wanneer je genoeg hebt om je upgrade te kopen
			print (Score.getScore);
			bought = true;
			Score.getScore -= price;
			this.enabled = false;
			//Text.color = Color.red;
			//Score.scoreMultiplier += increaseMoneyAmount;
		}
	}
	override protected void Update(){ //kleur Button
		if (Score.getScore >= price && !bought) {
			Text.color = Color.green;
		} 
		if(Score.getScore <= price){
			Text.color = Color.red;
		}
		Pricetag.text = (price + "$"); // houd de prijs bij
	}
}
