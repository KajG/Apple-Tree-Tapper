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
	public int amount;
	void Start () {
		_col = GetComponent<CircleCollider2D> ();
	}

	void Update () { 
		if (_apples.Count >= maxAppleCount) {
			RemoveApple ();
		}
	}
	public void MouseClick(){
		if (_apples.Count <= maxAppleCount) {
			//randomPos = new Vector3 (_col.transform.position.x + Random.Range (_col.radius * -1,_col.radius),_col.transform.position.y +  + _col.offset.y + Random.Range (_col.radius * -1,_col.radius),0);
			print (_col.radius);
			SpawnApple ();
		}
	}
	void SpawnApple(){
		for (int i = 0; i < amount; i++) {
			randomPos = new Vector3 (_col.transform.position.x + Random.Range (_col.radius * -1,_col.radius),_col.transform.position.y +  + _col.offset.y + Random.Range (_col.radius * -1,_col.radius),0);
			_appleInst = Instantiate (apple, randomPos, Quaternion.identity);
			_apples.Add (_appleInst);
		}
	}
	void RemoveApple(){
			Destroy (_apples [0]);
			_apples.RemoveAt (0);
	}
}
