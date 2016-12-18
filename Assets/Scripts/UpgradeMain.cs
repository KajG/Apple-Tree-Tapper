using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class UpgradeMain : MonoBehaviour {

	protected int price;
	[SerializeField]
	Button button;
	abstract protected void Start ();



	abstract protected void onClick ();
		
}
