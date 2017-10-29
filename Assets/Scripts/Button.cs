using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
	public Renderer rend;

	AudioSource audio; 

	void Start(){
		rend = GetComponent<Renderer>();
		rend.enabled = true;

		audio = GetComponent<AudioSource>();

	}
	void OnTouchDown(){
		audio.Play ();

		rend.enabled = false;

		Debug.Log ("Message Received");
	}
}
