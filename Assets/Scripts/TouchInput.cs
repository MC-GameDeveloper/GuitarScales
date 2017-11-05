using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour {

	public LayerMask touchInputMask;

	private RaycastHit hit;

	void Update () {

#if UNITY_EDITOR

	if (Input.GetMouseButton(0)) {
			//Debug.Log("Pressed");

		Ray ray = GetComponent<Camera> ().ScreenPointToRay (Input.mousePosition);﻿

		if (Physics.Raycast (ray, out hit, touchInputMask)) {
			GameObject recipient = hit.transform.gameObject;
			//Debug.Log("Hit");

			if (Input.GetMouseButton(0)) {
				recipient.SendMessage ("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
					//Debug.Log("Message Sent"); 
			}
		}
	}

#endif
		
		if (Input.touchCount > 0) {
			
			foreach (Touch touch in Input.touches) {
				Ray ray = GetComponent<Camera> ().ScreenPointToRay (touch.position);﻿

				if (Physics.Raycast (ray, out hit, touchInputMask)) {
					GameObject recipient = hit.transform.gameObject;

					if (touch.phase == TouchPhase.Began) {
						recipient.SendMessage ("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
					}
				}
			}
		}
	}
}
