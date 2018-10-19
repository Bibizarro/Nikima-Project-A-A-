using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthUI : MonoBehaviour {

	public GameObject[] UIHeart;
	int currentLife;

	void Update () {
		currentLife = Singleton.GetInstance.playerScript.health;

		if(currentLife > UIHeart.Length)
			return;
		else if(currentLife < 0){
			SceneManager.LoadScene(sceneBuildIndex: SceneManager.GetActiveScene().buildIndex);
			return;
		}

	}
	IEnumerator DestroingHeart(GameObject corazon)
	{

		corazon.GetComponent<SetGlitch>().GlitchNow();
		yield return new WaitForSeconds(0.5f);
		corazon.SetActive(false);
	}


	public void LifeCheck()
	{
		switch(currentLife)
		{

			case 2:
				StartCoroutine(DestroingHeart(UIHeart[2]));
			break;

			case 1:
				StartCoroutine(DestroingHeart(UIHeart[1]));
			break;

			case 0:
			StartCoroutine(DestroingHeart(UIHeart[0]));
			break;

		}
	}
}
