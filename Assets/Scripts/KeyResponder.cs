using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class KeyResponder : MonoBehaviour {
	private bool vrEnabled;
	// Use this for initialization
	void Start () {
		vrEnabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.X) && vrEnabled)
		{
			vrEnabled = false;
			Debug.Log ("X preseed");
			StartCoroutine(LoadDevice("NONE"));
		}
	}

	IEnumerator LoadDevice(string newDevice)
	{
		if (String.Compare(XRSettings.loadedDeviceName, newDevice, true) != 0)
		{
			//GameObject rh = GameObject.Find ("RightHand");
			//rh.GetComponent<TouchController>().controller = OVRInput.Controller.None;

			Debug.Log ("loading new device");
			XRSettings.LoadDeviceByName(newDevice);
			yield return null;
			XRSettings.enabled = true;
		}
	}
}
