using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {
    [SerializeField]
    private float speed;
    public int health;
    private Rigidbody2D rb;



	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
health = 3;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        print(health);
       if(Input.GetMouseButtonDown(0))
       {
           Singleton.GetInstance.cameraScript.CameraShake();
       }

       if(Input.GetKeyDown(KeyCode.X)){
			Fire();
		}
	}

void Fire(){
      GameObject obj =  ObjectPooler.instance.GetPooledObject();
		obj.transform.position = transform.position;
		obj.SetActive(true);}

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
