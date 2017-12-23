using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStructure : MonoBehaviour {

	public GameObject[] states;

	private int currentState;
	private Renderer rend;
	private Renderer nextRend;
	private bool progressForward = true;

	// Use this for initialization
	void Start () {
		currentState = 0;	
		rend = states [currentState].GetComponent<Renderer> ();
		rend.enabled = true;
	}

	public void NextState(){
		
		rend = states [currentState].GetComponent<Renderer> ();

		rend.enabled = false;

		if (progressForward) {
			if (currentState <= 10) {
				currentState++;	
				rend = states [currentState].GetComponent<Renderer> ();
				rend.enabled = true;
			} else if (currentState >= 11) {
				progressForward = false;
				rend.enabled = true;
				return;
			}
		} else {
			if (currentState > 0) {
				currentState--;
				rend = states [currentState].GetComponent<Renderer> ();
				rend.enabled = true;
			} else if (currentState <= 0) {
				progressForward = true;
				rend.enabled = true;
			}
		}
	}
}
