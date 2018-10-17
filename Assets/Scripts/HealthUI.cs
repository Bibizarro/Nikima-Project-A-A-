using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthUI : MonoBehaviour {

	public Sprite[] healthSprites;
	public Image UIsprite;

	void Update () {
		int currentLife = Singleton.GetInstance.playerScript.health;

		if(currentLife > healthSprites.Length)
			return;
		else if(currentLife < 0){
			SceneManager.LoadScene(sceneBuildIndex: SceneManager.GetActiveScene().buildIndex);
			return;
		}

		UIsprite.sprite = healthSprites[currentLife];
	}
}
