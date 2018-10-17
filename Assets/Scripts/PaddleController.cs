using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

    
    public int health;
    public int ballCount;
    public int ballsHitted;
    public int activeBall;
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private BallCount ballCountScript;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        health = 3;
        activeBall = 0;
        ballCount = 3;
        ballCountScript.UpdateUI(ballCount);
	}
	
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

    void AddingBalls()
    {
        if (ballsHitted == 3)
        {
            //Add a ball;
            ballsHitted = 0;
            if(ballCount < 8){
                ballCount++;
                ballCountScript.UpdateUI(ballCount);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "GreenBall" || coll.gameObject.tag == "OrangeBall" || coll.gameObject.tag == "BlueBall" || coll.gameObject.tag == "PinkBall")
        {
            ballsHitted++;
            AddingBalls();
        }
    }


}
