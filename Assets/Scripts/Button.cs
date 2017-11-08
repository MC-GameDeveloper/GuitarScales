using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	private AudioSource audio; 
	private Renderer rend;

	void Start(){

		audio = GetComponent<AudioSource>();
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
	}

	void OnTouchDown(){
		
		audio.Play ();
		//Debug.Log ("Music!");
		rend.enabled = false;
	}
}
