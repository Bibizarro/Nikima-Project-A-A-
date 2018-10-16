using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour {

	[SerializeField] private float offset;
	public float rotZ;

	void Start () {
		
	}

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Shot();
		}
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
	}
	void Shot(){
		var obj =  ObjectPooler.instance.GetPooledObject();
		if(obj != null){
			obj.transform.position = transform.position;
			obj.SetActive(true);
		}

	}
}
