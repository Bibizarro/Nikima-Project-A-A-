using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

    [SerializeField]
	private int speed;

    private float axisX;

	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Movement()
    {
        axisX = Input.GetAxisRaw("Horizontal");
    }
}
