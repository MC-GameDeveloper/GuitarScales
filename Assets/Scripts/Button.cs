using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public AudioSource audio; 

	void Start(){

		audio = GetComponent<AudioSource>();
		if (audio) {
			Debug.Log ("We've got component");
		}
	}

	void OnTouchDown(){
		
		audio.Play ();
		Debug.Log ("Music!");
		Destroy (gameObject);
	}
}
