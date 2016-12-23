using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class CreateApple : MonoBehaviour {


	public List<GameObject> _apples;
	private GameObject _appleInst;
	public GameObject apple;
	public int maxAppleCount;
	private Vector3 randomPos;
	private CircleCollider2D _col;
	public int appleAmount;
	void Start () {
		_col = GetComponent<CircleCollider2D> ();
	}

	void Update () { 
		if (_apples.Count >= maxAppleCount) { // als er teveel apples zijn
			//RemoveApple ();
		}
	}
	public void MouseClick(){
		if (_apples.Count <= maxAppleCount - 1) { // als er niet genoeg apples zijn kan je ze laten spawnen
			SpawnApple ();
		}
	}
	void SpawnApple(){
		for (int i = 0; i < appleAmount; i++) { //loopt zoveel keer als amount is, dit zorgt ervoor dat je 3 apples tegelijk kan laten spawnen
			randomPos = new Vector3 (_col.transform.position.x + Random.Range (_col.radius * -1,_col.radius),_col.transform.position.y +  + _col.offset.y + Random.Range (_col.radius * -1,_col.radius),0);
			_appleInst = Instantiate (apple, randomPos, Quaternion.identity);
			_appleInst.tag = "Apple";
			_apples.Add (_appleInst);
		}
	}
	void RemoveApple(){
			Destroy (_apples [0]);
			_apples.RemoveAt (0);
	}
}
