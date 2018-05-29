using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMove : MonoBehaviour {
	private GameObject target;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		target = transform.parent.GetComponent<Sword> ().controller;
	}
	
	void FixedUpdate () {
		if (target == null) {
			return;
		}
		Vector3 delta = target.transform.position - transform.position;
		rb.AddForce((delta) * 50F);
		rb.AddForce((delta - rb.velocity) * 5F);
		if (delta.magnitude < 0.2) {
			rb.AddForce (rb.velocity* -5F);
		}

		Quaternion quat0;
		Quaternion quat1;
		Quaternion quat10;
		quat0=transform.rotation;
		quat1=target.transform.rotation;
		quat10=quat1*Quaternion.Inverse(quat0);
		rb.AddTorque(quat10.x*20F,quat10.y*20F,quat10.z*20F,ForceMode.Force);

		rb.angularDrag = 0.8F;
	}
}
