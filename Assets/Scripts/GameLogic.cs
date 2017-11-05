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

	void Start () {
		
		NoteOnSixthPlay ();
	}

	void Update(){

		if (noteOnSixthRef == null) {
			SecondNotePlay ();
			Debug.Log ("note Destroyed");
		} else if (secondNoteRef == null) {
			ThirdNotePlay ();
		}else if (thirdNoteRef == null) {
			FourthNotePlay ();
		}else if (fourthNoteRef == null) {
			FifthNotePlay ();
		}else if (fifthNoteRef == null) {
			RootNotePlay ();
		}else if (rootRef == null) {
			SeventhNotePlay ();
		}else if (seventhNoteRef == null) {
			EigthNotePlay ();
		}else if (eigthNoteRef == null) {
			NinthNotePlay ();
		}else if (ninthNoteRef == null) {
			TenthNotePlay ();
		}else if (tenthNoteRef== null) {
			RootTwoNotePlay ();
		}else if (rootTwoRef == null) {
			TwelthNotePlay ();
		}else if (twelthNoteRef == null) {
			NoteOnSixthPlay ();
		}
	}
		
	void NoteOnSixthPlay(){
		
		Instantiate (noteOnSixthRef);
	}

	void SecondNotePlay(){
		
		Instantiate (secondNoteRef);
	}
	void ThirdNotePlay(){

		Instantiate (thirdNoteRef);
	}
	void FourthNotePlay(){

		Instantiate (fourthNoteRef);
	}
	void FifthNotePlay(){

		Instantiate (fifthNoteRef);
	}
	void RootNotePlay(){

		Instantiate (rootRef);
	}
	void SeventhNotePlay(){

		Instantiate (seventhNoteRef);
	}
	void EigthNotePlay(){

		Instantiate (eigthNoteRef);
	}
	void NinthNotePlay(){

		Instantiate (ninthNoteRef);
	}
	void TenthNotePlay(){

		Instantiate (tenthNoteRef);
	}
	void RootTwoNotePlay(){

		Instantiate (rootTwoRef);
	}
	void TwelthNotePlay(){

		Instantiate (twelthNoteRef);
	}
}
