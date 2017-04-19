using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardTarget : MonoBehaviour {
	public Transform target;
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = target.position-transform.position;
		Debug.DrawRay (transform.position, dir, Color.magenta);

		dir	= new Vector3 (dir.x / dir.magnitude, dir.y / dir.magnitude, dir.z / dir.magnitude);
		//Normalize will normalize the vector, change the value inside the vector; normalized will return a normalized vector but not change the value in the original one

		Debug.Log ("normalized dir :" + dir.magnitude);


		Debug.Log ("Facing :" + transform.forward);
		if (Vector3.Dot(transform.forward, dir)>0){
			Debug.DrawRay (transform.position, dir, Color.cyan);
			transform.Translate (dir*speed*Time.deltaTime);
		}
	}
}
