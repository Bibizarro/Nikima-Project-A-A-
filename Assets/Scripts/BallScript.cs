using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public Transform paddle;
 
	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private float ballForce;

	void OnEnable() {
		//rb.AddForce(new Vector2(ballForce, ballForce));
		Shot();
	}

	void Update () 
	{
		
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

	void Shot(){
		var rotationZ = Singleton.GetInstance.ballShot.rotZ;

		if(rotationZ < 0){
			Vector3 dir = Quaternion.AngleAxis(rotationZ, Vector3.forward) * Vector3.right;
  			rb.AddForce(dir * ballForce);
		}
		//rb.AddForce(transform.forward * ballForce);
	}
}
