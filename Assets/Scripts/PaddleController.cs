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

    public Animator animLeftArrow;
    public Animator animRightArrow;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        health = 3;
        activeBall = 0;
        ballCount = 3;
        ballCountScript.UpdateUI(ballCount);
	}

    private void Update() {
        
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-2.18f ,2.18f) , transform.position.y);
        rb.velocity = new Vector2 (Mathf.Clamp(rb.velocity.x ,-speed * Time.deltaTime, speed * Time.deltaTime) , rb.velocity.y);
    }

    public void MoveRight()
    {
        rb.velocity = new Vector2(speed * Time.deltaTime, rb.velocity.y);
        animRightArrow.SetInteger("glitching", Mathf.RoundToInt(rb.velocity.x));
    }
    public void MoveLeft()
    {
        rb.velocity = new Vector2(-speed * Time.deltaTime, rb.velocity.y);
         animLeftArrow.SetInteger("glitching", Mathf.RoundToInt(rb.velocity.x));
    }

    public void StopMoveRight()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
         animRightArrow.SetInteger("glitching", Mathf.RoundToInt(rb.velocity.x));
    }
    public void StopMoveLeft()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
         animLeftArrow.SetInteger("glitching", Mathf.RoundToInt(rb.velocity.x));
      
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "GreenBall" || coll.gameObject.tag == "OrangeBall" || coll.gameObject.tag == "BlueBall" || coll.gameObject.tag == "PinkBall")
        {
            ballsHitted++;
            AddingBalls();
        }
    }

    void AddingBalls()
    {
        if (ballsHitted == 3)
        {
            //Add a ball;
            ballsHitted = 0;
            if(ballCount < 8 && (ballCount + activeBall) < 8){
                ballCount++;
                ballCountScript.UpdateUI(ballCount);
            }
        }
    }

    public void DecreasingBalls(){
        activeBall++;
	    ballCount--;
		ballCountScript.UpdateUI(ballCount);
    }

}
