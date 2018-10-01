using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject player;
    public Vector2 playerPos;



    void Start () {
      player = Singleton.GetInstance.player;
        playerPos = new Vector2(0, -4);
       // Instantiate()
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
