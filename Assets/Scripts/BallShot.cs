using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour {

	public float offset;

	void Start () {
		
	}

	void Update () {
		LookAtTouch(Camera.main.ScreenToWorldPoint(Input.mousePosition));
	}

	void LookAtTouch(Vector3 mouseInput){
		Vector3 difference = mouseInput - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
	}
}
