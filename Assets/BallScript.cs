using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public Transform paddle;

	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private float ballForce;
	[SerializeField] private float time;
	private bool canShot;

	void Start () {
		canShot = true;
	}

	void OnEnable() {
		rb.AddForce(new Vector2(ballForce, ballForce));
	}

	void Update () {
		if(Input.GetKey(KeyCode.X) && canShot){
			Fire();
		StartCoroutine(ShotTime());
		}
	}
	void Fire(){
		if(paddle == null){
			paddle = Singleton.GetInstance.paddleTransform;
			return;
		}
		GameObject obj =  ObjectPooler.instance.GetPooledObject();
		obj.transform.position = paddle.position;
		obj.SetActive(true);
	}
	IEnumerator ShotTime(){
		canShot = false;
		yield return new WaitForSeconds(time);
	}
}
