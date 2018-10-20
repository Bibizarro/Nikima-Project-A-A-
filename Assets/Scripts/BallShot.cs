using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour {

	public float rotZ;

	public GameObject angleArrow;
	public BallCount ballCount;
	[SerializeField] private float offset;
	[SerializeField] private float[] limits;

    void Start() 
	{
		angleArrow.SetActive(false);
	}
	void Update () {
        if(Input.GetMouseButtonDown(0))
		{
			angleArrow.SetActive(true);
		}

		if(Input.GetMouseButtonUp(0) && rotZ > 0)
		{
			print("mouseUp");
			angleArrow.SetActive(false);
			PaddleController playerScript = Singleton.GetInstance.playerScript;
			if(playerScript.ballCount > 0)
			{
				Shot(playerScript);
			}
		}

		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

		if(rotZ >= 0)  //Como rotZ pode assumir valores negativos, nós simplesmente ignoramos eles(vals. negativos) pq eles ficariam apontando para "baixo"
		{
			rotZ = Mathf.Clamp(rotZ, limits[0], limits[1]);
			transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
		}
	}
	void Shot(PaddleController playerScript){
		var obj =  ObjectPooler.instance.GetPooledObject();

		if(obj != null){
			obj.transform.position = transform.position;
			obj.SetActive(true);
			playerScript.DecreasingBalls();
		}

	}
}
