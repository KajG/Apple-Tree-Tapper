using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class UpgradeMain : MonoBehaviour {
	[SerializeField]
	protected int price;
	[SerializeField]
	protected int cashMultiplier;
	protected bool bought;
	public ScoreController score;
	public Button button;
	abstract protected void Start ();
	abstract public void onClick ();
}
