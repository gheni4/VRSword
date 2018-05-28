using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TouchController : NetworkBehaviour {
	public OVRInput.Controller controller;

	// Update is called once per frame
	void Update () {
		if (transform.parent.gameObject.GetComponent<NetworkIdentity>().isLocalPlayer) {
			transform.localPosition = OVRInput.GetLocalControllerPosition (controller);
			transform.localRotation = OVRInput.GetLocalControllerRotation (controller);
		}
	}
}
