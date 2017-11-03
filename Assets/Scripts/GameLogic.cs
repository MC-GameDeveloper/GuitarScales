using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
	


	private bool beginningOfScale = true;
	private GameObject[] buttons = GameObject.FindGameObjectsWithTag ("Note");
	//private Button buttonScript = buttons.GetComponents<Button> ();


	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if (beginningOfScale) {
			for (int i = 0; i < buttons.Length; i++) {
				
			} 
		}
	}
		
	//void methord(){

		//if(beginning of scale);{
			//foreach...
			//get index of button just pressed then work turn off renderer and enable renderer of i++
			//set beginning of scale to false
		//}

		//elseif(not at beginning of scale){
			//foreach...	
			//use reverse array and turn on and off renderers
			//set beginning of scale to true
		//}

	//}
}
