using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public GameObject noteOnSixthRef;
	public GameObject secondNoteRef;
	public GameObject thirdNoteRef;
	public GameObject fourthNoteRef;
	public GameObject fifthNoteRef;
	public GameObject rootRef;
	public GameObject seventhNoteRef;
	public GameObject eigthNoteRef;
	public GameObject ninthNoteRef;
	public GameObject tenthNoteRef;
	public GameObject rootTwoRef;
	public GameObject twelthNoteRef;

	private Renderer noteOnSixthCloneRend;
	private Renderer secondNoteCloneRend;
	private Renderer thirdNoteCloneRend;
	private Renderer fourthNoteCloneRend;
	private Renderer fifthNoteCloneRend;
	private Renderer rootCloneRend;
	private Renderer seventhNoteCloneRend;
	private Renderer eigthNoteCloneRend;
	private Renderer ninthNoteCloneRend;
	private Renderer tenthNoteCloneRend;
	private Renderer rootTwoCloneRend;
	private Renderer twelthNoteCloneRend;

	private int noteOnSixthNumb;
	private int secondNoteNumb;
	private int thirdNoteNumb;
	private int fourthNoteNumb;
	private int fifthNoteNumb;
	private int rootNumb;
	private int seventhNoteNumb;
	private int eigthNoteNumb;
	private int ninthNoteNumb;
	private int tenthNoteNumb;
	private int rootTwoNumb;
	private int twelthNoteNumb;

	private GameObject noteOnSixthClone;
	private GameObject secondNoteClone;
	private GameObject thirdNoteClone;
	private GameObject fourthNoteClone;
	private GameObject fifthNoteClone;
	private GameObject rootClone;
	private GameObject seventhNoteClone;
	private GameObject eigthNoteClone;
	private GameObject ninthNoteClone;
	private GameObject tenthNoteClone;
	private GameObject rootTwoClone;
	private GameObject twelthNoteClone;




	void Start () {
		
		NoteOnSixthPlay ();

	}
		
	void NoteOnSixthPlay(){
		
		noteOnSixthClone = Instantiate (noteOnSixthRef);
		noteOnSixthNumb++;
		noteOnSixthCloneRend = noteOnSixthClone.GetComponent<Renderer> ();
		noteOnSixthCloneRend.enabled = true;
		Debug.Log ("1");

	}

	void SecondNotePlay(){
		
		secondNoteClone = Instantiate (secondNoteRef);
		secondNoteNumb++;
		secondNoteCloneRend = secondNoteClone.GetComponent<Renderer> ();
		secondNoteCloneRend.enabled = true;
		Debug.Log ("2");

	}
	void ThirdNotePlay(){

		thirdNoteClone = Instantiate (thirdNoteRef);
		thirdNoteNumb++;
		thirdNoteCloneRend = thirdNoteClone.GetComponent<Renderer> ();
		thirdNoteCloneRend.enabled = true;
		Debug.Log ("3");

	}
	void FourthNotePlay(){

		fourthNoteClone = Instantiate (fourthNoteRef);
		fourthNoteNumb++;
		fourthNoteCloneRend = fourthNoteClone.GetComponent<Renderer> ();
		fourthNoteCloneRend.enabled = true;
		Debug.Log ("4");

	}
	void FifthNotePlay(){

		fifthNoteClone = Instantiate (fifthNoteRef);
		fifthNoteNumb++;
		fifthNoteCloneRend = fifthNoteClone.GetComponent<Renderer> ();
		fifthNoteCloneRend.enabled = true;
		Debug.Log ("5");

	}
	void RootNotePlay(){

		rootClone = Instantiate (rootRef);
		rootNumb++;
		rootCloneRend = rootClone.GetComponent<Renderer> ();
		rootCloneRend.enabled = true;
		Debug.Log ("6");
	}
	void SeventhNotePlay(){

		seventhNoteClone = Instantiate (seventhNoteRef);
		seventhNoteNumb++;
		seventhNoteCloneRend = seventhNoteClone.GetComponent<Renderer> ();
		seventhNoteCloneRend.enabled = true;
		Debug.Log ("7");

	}
	void EigthNotePlay(){

		eigthNoteClone = Instantiate (eigthNoteRef);
		eigthNoteNumb++;
		eigthNoteCloneRend = eigthNoteClone.GetComponent<Renderer> ();
		eigthNoteCloneRend.enabled = true;
		Debug.Log ("8");
	}
	void NinthNotePlay(){

		ninthNoteClone = Instantiate (ninthNoteRef);
		ninthNoteNumb++;
		ninthNoteCloneRend = ninthNoteClone.GetComponent<Renderer> ();
		ninthNoteCloneRend.enabled = true;
		Debug.Log ("9");

	}
	void TenthNotePlay(){

		tenthNoteClone = Instantiate (tenthNoteRef);
		tenthNoteNumb++;
		tenthNoteCloneRend = tenthNoteClone.GetComponent<Renderer> ();
		tenthNoteCloneRend.enabled = true;
		Debug.Log ("10");

	}
	void RootTwoNotePlay(){

		rootTwoClone = Instantiate (rootTwoRef);
		rootTwoNumb++;
		rootTwoCloneRend = rootTwoClone.GetComponent<Renderer> ();
		rootTwoCloneRend.enabled = true;
		Debug.Log ("11");

	}
	void TwelthNotePlay(){

		twelthNoteClone = Instantiate (twelthNoteRef);
		twelthNoteNumb++;
		twelthNoteCloneRend = twelthNoteClone.GetComponent<Renderer> ();
		twelthNoteCloneRend.enabled = true;
		Debug.Log ("12");

	}
	void Update(){

		if (noteOnSixthCloneRend.enabled == false && noteOnSixthClone && secondNoteNumb <= 1 && !secondNoteClone) {
			
				SecondNotePlay ();

		} 
		if (secondNoteCloneRend.enabled == false && secondNoteClone && thirdNoteNumb <= 1 && !thirdNoteClone) {
			
				ThirdNotePlay ();

		}
		if (thirdNoteCloneRend.enabled == false && thirdNoteClone && fourthNoteNumb <= 1 && !fourthNoteClone) {
			
				FourthNotePlay ();

		}
		if (fourthNoteCloneRend.enabled == false && fourthNoteClone && fifthNoteNumb <= 1 && !fifthNoteClone) {
			
				FifthNotePlay ();

		}
		if (fifthNoteCloneRend.enabled == false && fifthNoteClone && rootNumb <= 1 && !rootClone) {
			
				RootNotePlay ();

		}
		if (rootCloneRend.enabled == false && rootClone && seventhNoteNumb <= 1 && !seventhNoteClone) {
			
				SeventhNotePlay ();

		}
		if (seventhNoteCloneRend.enabled == false && seventhNoteClone && eigthNoteNumb <= 1 && !eigthNoteClone) {
			
				EigthNotePlay ();

		}
		if (eigthNoteCloneRend.enabled == false && eigthNoteClone && ninthNoteNumb <= 1 && !ninthNoteClone) {
			
				NinthNotePlay ();

		}
		if (ninthNoteCloneRend.enabled == false && ninthNoteClone && tenthNoteNumb <= 1 && !tenthNoteClone) {
			
				TenthNotePlay ();

		}
		if (tenthNoteCloneRend.enabled == false && tenthNoteClone && rootTwoNumb <= 1 && !rootTwoClone) {
			
				RootTwoNotePlay ();

		}
		if (rootTwoCloneRend.enabled == false && rootTwoClone && twelthNoteNumb <= 1 && !twelthNoteClone) {
			
				TwelthNotePlay ();
		}
	}
}
