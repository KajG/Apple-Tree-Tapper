using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Upgrade1 : UpgradeMain {
	
	override protected void Start () {
		button = button.GetComponent<Button> ();
		score = score.GetComponent<ScoreController> ();
		text = text.GetComponent<Text> ();
	}
	
	override public void onClick(){
		if (score.getScore > price && !bought) {
			print (score.getScore);
			bought = true;
			score.getScore -= price;
			score.getScoreAmount += cashMultiplier;
			this.enabled = false;
			text.color = Color.red;
		}
	}
	override protected void Update(){
		if (score.getScore >= price && !bought) {
			text.color = Color.green;
		} else {
			text.color = Color.red;
		}

	}

}
