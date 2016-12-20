using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Upgrade2 : UpgradeMain {

	override protected void Start () {
		button = button.GetComponent<Button> ();
		score = score.GetComponent<ScoreController> ();
		text = text.GetComponent<Text> ();
	}
	override public void onClick(){
		if (score.getScore >= price && !bought) { //Wanner je genoeg hebt om je upgrade te kopen
			print (score.getScore);
			bought = true;
			score.getScore -= price;
			this.enabled = false;
			text.color = Color.red;
			score.scoreMultiplier += increaseMoneyAmount;
		}
	}
	override protected void Update(){ //kleur button
		if (score.getScore >= price && !bought) {
			text.color = Color.green;
		} else {
			text.color = Color.red;
		}
	}
}
