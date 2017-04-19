using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowardTarget : MonoBehaviour {
	public Transform target;
	public float speed = 0.5f;
	public float force = 10f;
	private Vector3 origin = new Vector3(0,0,0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = target.position-transform.position;
		//Debug.DrawRay (transform.position, dir, Color.magenta);

		dir	= new Vector3 (dir.x / dir.magnitude, dir.y / dir.magnitude, dir.z / dir.magnitude);
		//Normalize will normalize the vector, change the value inside the vector; normalized will return a normalized vector but not change the value in the original one

		Debug.Log ("normalized dir :" + dir.magnitude);


		Debug.Log ("Facing :" + transform.forward);
		if (Vector3.Dot(transform.forward, dir)>0){
			Debug.DrawRay (transform.position, dir, Color.cyan);
			transform.Translate (dir*speed*Time.deltaTime);
			//transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation, 0.1f);
		}
		Debug.DrawRay (transform.position, transform.forward*10, Color.black);
		Debug.DrawRay (transform.position, transform.up * 10, Color.black);

		/*GameObject ball1 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		ball1.AddComponent<Rigidbody> ();
		Rigidbody rb1 = ball1.GetComponent<Rigidbody> ();
		rb1.AddForce (transform.right * force);*/

		Vector3 cross = Vector3.Cross (transform.forward, transform.up);
		Debug.DrawRay (origin, cross, Color.red);
		GameObject ball1 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		//ball1.transform.Translate (cross * speed * Time.deltaTime);
		ball1.AddComponent<Rigidbody> ();
		Rigidbody rb1 = ball1.GetComponent<Rigidbody> ();
		rb1.AddForce (Vector3.Normalize(cross) * force);

		GameObject ball2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		ball2.AddComponent<Rigidbody> ();
		Rigidbody rb2 = ball2.GetComponent<Rigidbody> ();
		rb2.AddForce (Vector3.Normalize(cross) * force);

	}
}
