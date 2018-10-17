using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthUI : MonoBehaviour {

	public Sprite[] healthSprites;
	public Image UIsprite;

	void Update () {
		int currentLife = Singleton.GetInstance.playerScript.health;

		if(currentLife > healthSprites.Length || currentLife < 0) 
			return;

		UIsprite.sprite = healthSprites[currentLife];
	}
}
