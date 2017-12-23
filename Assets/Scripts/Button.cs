using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	private AudioSource audio;
	private Renderer rend;
	public GameStructure gameStructureRef;
	void Start(){

		audio = GetComponent<AudioSource>();
		rend = GetComponent<Renderer> ();

	}

	void OnTouchDown(){
		audio.Play ();
		if (rend.enabled == true) {
			gameStructureRef.NextState ();
		}
	}
}
