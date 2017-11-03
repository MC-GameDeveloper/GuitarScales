using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
	public Renderer rend;
	public bool buttonJustPressed = false;

	private AudioSource audio; 

	void Start(){
		
		audio = GetComponent<AudioSource>();
		rend = GetComponent<Renderer>();
		rend.enabled = false;

	}
	void OnTouchDown(){
		
		audio.Play ();

		rend.enabled = false;

		buttonJustPressed = true;
		Debug.Log ("Message Received");
	}
}
