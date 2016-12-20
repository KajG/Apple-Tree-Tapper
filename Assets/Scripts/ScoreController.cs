using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour {

	public CreateApple appleCount;
	public Text scoreText;
	[SerializeField]
	private float score;
	public float getScore{get{return score;}set{score = value;}}
	public CreateApple appleAmount;
	[SerializeField]
	public float scoreMultiplier = 1;

	void Start () {
		appleAmount = appleAmount.GetComponent<CreateApple> ();
	}
	
	void Update () { //laat scoren zien
		scoreText.text = ("Money: " + Mathf.RoundToInt(score) + "$");
	}
	public void GetScore(){ // add je score elke keer als je klikt
		score += appleAmount.appleAmount * scoreMultiplier;
	}
}
