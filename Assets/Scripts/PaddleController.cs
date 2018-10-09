using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {
    [SerializeField]
    private float speed;
    private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

		
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}


    public void MoveRight()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
    }
    public void MoveLeft()
    {
        rb.velocity = new Vector2(-speed * Time.deltaTime, rb.velocity.y);
    }

    public void StopMoveRight()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
    public void StopMoveLeft()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
      
    }


}
