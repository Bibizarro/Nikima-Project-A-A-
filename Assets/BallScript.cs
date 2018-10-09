using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public Transform paddle;

	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private float ballForce;

	void OnEnable() {
		rb.AddForce(new Vector2(ballForce, ballForce));
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.X)){
			Fire();
		}
	}
	void Fire(){
		
		paddle = Singleton.GetInstance.paddleTransform;
		GameObject obj =  ObjectPooler.instance.GetPooledObject();
		obj.transform.position = paddle.position;
		obj.SetActive(true);
	}
}
