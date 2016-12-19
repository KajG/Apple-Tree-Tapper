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
	public float scoreMultiplier;

	void Start () {
		appleAmount = appleAmount.GetComponent<CreateApple> ();
	}
	
	void Update () {
		scoreText.text = ("Money: " + score + "$");
	}
	public void Score(){
		score += appleAmount.appleAmount * ((scoreMultiplier + 1) * 1);
	}
}
