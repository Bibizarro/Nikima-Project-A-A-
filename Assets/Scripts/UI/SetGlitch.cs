using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGlitch : MonoBehaviour {

	Animator anim;
	public float delayTime;

	public bool glitchAll;
	void Start () {
		anim = GetComponent<Animator>();
		StartCoroutine("GlitchWithTime");
		StartCoroutine("GlitchAll");
	}
	

	public void GlitchNow()
	{
		 anim.SetTrigger("glitching");
	}

	IEnumerator GlitchWithTime()
	{
     yield return new WaitForSeconds(delayTime);
	 anim.SetTrigger("glitching");
	 StartCoroutine("GlitchWithTime");
	}

	IEnumerator GlitchAll()
	{
		if(glitchAll){
     yield return new WaitForSeconds(10f);
	 BroadcastMessage("GlitchNow");
	 }
	 
	}


}
