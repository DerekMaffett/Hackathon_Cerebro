using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class PreventCameraAndMovement : NetworkBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		//intercept camerea and controls
		if (!isLocalPlayer) {
//			GetComponent<CharacterMotor>().enabled = false;

			Camera cam = GetComponentInChildren<Camera> ();
			cam.enabled = false;
		}
	}
}
