using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour {

	public CreateApple appleCount;
	public Text scoreText;
	[SerializeField]
	private int score;
	[SerializeField]
	private int scoreAmount;
	[SerializeField]
	private int scoreMultiplier;

	void Start () {
		
	}
	
	void Update () {
		scoreMultiplier = appleCount._apples.Count / 10 + 1;
		scoreText.text = ("Money: " + score + "$");
	}
	public void Score(){
		score += (scoreAmount * scoreMultiplier) ;
	}
}
