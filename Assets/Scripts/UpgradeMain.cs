using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class UpgradeMain : MonoBehaviour {
	[SerializeField]
	protected int price;
	[SerializeField]
	protected bool bought = false;
	[SerializeField]
	protected float buttonMoneyEffect;
	public Text text;
	public ScoreController score;
	public Button button;
	abstract protected void Start ();
	abstract protected void Update ();
	abstract public void onClick ();
}
