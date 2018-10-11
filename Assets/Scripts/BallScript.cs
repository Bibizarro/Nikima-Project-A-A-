using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public Transform paddle;

	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private float ballForce;

	public Vector3 direction;
	public Transform target;
	
	void OnEnable(){
		rb.AddForce(direction * ballForce);
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if(coll.gameObject.tag == "ScreenBottom")
		{
			Singleton.GetInstance.cameraScript.CameraShake();
			Singleton.GetInstance.playerScript.health-=1;
			gameObject.SetActive(false);
		}
	}

	Vector2 ToVector2(Vector3 value){
		return (Vector2) value;
	}

	void Update () {
		Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		direction = (target - transform.localPosition).normalized;
		direction.y = Mathf.Sin(30 * Mathf.PI / 180);
	}
}
