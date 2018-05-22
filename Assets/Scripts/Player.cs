using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public GameObject swordPrefab;
	// Use this for initialization
	void Start() {
		Debug.Log("is local");
		GameObject sword = Instantiate(swordPrefab) as GameObject; 
		sword.GetComponent<Sword> ().controller = transform.GetChild(1).gameObject;
	}
}
