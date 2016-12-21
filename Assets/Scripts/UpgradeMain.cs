using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class UpgradeMain : MonoBehaviour {
	[SerializeField]
	protected int price;
	[SerializeField]
	protected float increaseMoneyAmount;
	[SerializeField]
	protected int increaseApples;
	[SerializeField]
	protected int priceIncrease;
	public Text Text;
	public Text Pricetag;
	public ScoreController Score;
	public CreateApple Createapple;
	public Button Button;
	abstract protected void Start ();
	abstract protected void Update ();
	abstract public void onClick ();
}
