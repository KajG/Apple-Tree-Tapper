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
	void Start () {
		_col = GetComponent<CircleCollider2D> ();
	}

	void Update () { 
		if (Input.GetKeyDown (KeyCode.E)) {
		}
	}
	public void MouseClick(){
		if (_apples.Count <= maxAppleCount) {
			randomPos = new Vector3 (_col.transform.position.x + Random.Range (_col.radius * -1,_col.radius),_col.transform.position.y +  + _col.offset.y + Random.Range (_col.radius * -1,_col.radius),0);
			print(_col.radius);
			SpawnApple ();
		} else {
			randomPos = new Vector3 (_col.transform.position.x + Random.Range (_col.radius * -1,_col.radius),_col.transform.position.y +  + _col.offset.y + Random.Range (_col.radius * -1,_col.radius),0);
			Destroy (_apples [0]);
			_apples.RemoveAt (0);
			SpawnApple ();
		}
	}
	void SpawnApple(){
		_appleInst = Instantiate (apple, randomPos, Quaternion.identity);
		_apples.Add (_appleInst);
	}
}
