using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour {

	public ParticleSystem pSystem;
	[SerializeField]
	private int particleAmount;

	void Start () {
		//pSystem = GetComponent<ParticleSystem> ();
	}
	
	void Update () {
		
	}
	public void pBurst(){
		pSystem.Emit (particleAmount);
	}
}
