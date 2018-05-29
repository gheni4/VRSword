using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {
	public GameObject swordPrefab;
	public GameObject cameraPrefab;
	// Use this for initialization
	void Start() {
		Debug.Log("starting");
		if (isLocalPlayer) {
			GameObject camera = Instantiate(cameraPrefab) as GameObject;
			camera.transform.parent = transform;
		}

		GameObject sword = Instantiate(swordPrefab) as GameObject; 
		sword.GetComponent<Sword>().controller = transform.GetChild (0).gameObject;
	}
}
