﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public Transform paddle;
 
	[SerializeField] private Rigidbody2D rb;
	[SerializeField] private CircleCollider2D circleColl;
	[SerializeField] private float ballForce;
	[SerializeField] private ParticleSystem particleSystem;
	[SerializeField] private Material[] materials;

	void OnEnable() {
		Shot();
		Invoke("IgnoreCollision", 0.5f);
	}

    #region PhysicsUpdate
    void OnTriggerEnter2D (Collider2D coll)
	{
		if(coll.gameObject.tag == "ScreenBottom")
		{
			Singleton.GetInstance.cameraScript.CameraShake();
			Singleton.GetInstance.playerScript.health -= 1;
			Singleton.GetInstance.healthUI.LifeCheck(Singleton.GetInstance.playerScript.health);
			Singleton.GetInstance.playerScript.ballsHitted = 0;
			Singleton.GetInstance.playerScript.activeBall--;
			gameObject.SetActive(false);
		}
	}

    void FixedUpdate()
    {
<<<<<<< HEAD
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -6, 6), Mathf.Clamp(rb.velocity.y, -6, 6));   
=======
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -4, 4), Mathf.Clamp(rb.velocity.y, -4, 4));   
>>>>>>> cf0a8a87b4d97d648c47c477ee0e61fe8a577875
    }
    #endregion PhysicsUpdate

    #region Functions
    void Shot(){
		var rotationZ = Singleton.GetInstance.ballShot.rotZ;
		Vector3 dir = Quaternion.AngleAxis(rotationZ, Vector3.forward) * Vector3.right;
  		rb.AddForce(dir * ballForce);
	}

	void IgnoreCollision(){
		circleColl = GetComponent<CircleCollider2D>();
		circleColl.enabled = true;
	}

	void RandomMaterial(){
		
	}
    #endregion Functions
<<<<<<< HEAD
}
=======
}
>>>>>>> cf0a8a87b4d97d648c47c477ee0e61fe8a577875
