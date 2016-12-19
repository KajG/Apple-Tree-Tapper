using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Upgrade1 : UpgradeMain {
	
	override protected void Start () {
		bought = false;
		button = button.GetComponent<Button> ();
		score = score.GetComponent<ScoreController> ();
	}
	
	override public void onClick(){
		if (score.getScore > price && !bought) {
			print (score.getScore);
			bought = true;
			score.getScore -= price;
			score.getScoreAmount += cashMultiplier;
			this.enabled = false;
		}
	}

}
