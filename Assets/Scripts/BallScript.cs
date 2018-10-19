using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public Transform paddle;
 
	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private float ballForce;
	[SerializeField] private ParticleSystem particleSystem;
	[SerializeField] private Material[] materials;

	void OnEnable() {
		Shot();
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if(coll.gameObject.tag == "ScreenBottom")
		{
			Singleton.GetInstance.cameraScript.CameraShake();
			Singleton.GetInstance.playerScript.health -= 1;
			Singleton.GetInstance.healthUI.LifeCheck();
			Singleton.GetInstance.playerScript.ballsHitted = 0;
			Singleton.GetInstance.playerScript.activeBall--;
			gameObject.SetActive(false);
		}
	}

	void Shot(){
		var rotationZ = Singleton.GetInstance.ballShot.rotZ;
		Vector3 dir = Quaternion.AngleAxis(rotationZ, Vector3.forward) * Vector3.right;
  		rb.AddForce(dir * ballForce);
	}

	void RandomMaterial(){
		
	}
}
