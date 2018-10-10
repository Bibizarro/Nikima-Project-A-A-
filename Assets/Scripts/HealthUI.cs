using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthUI : MonoBehaviour {

public Sprite[] healthSprites;

public Image UIsprite;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		UIsprite.sprite = healthSprites[Singleton.GetInstance.playerScript.health];
		
	}
}
