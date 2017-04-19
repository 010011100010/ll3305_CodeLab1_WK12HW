using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorMath : MonoBehaviour {
	public Vector3 startPoint = new Vector3 (0, 0, 0); //this is a constructor!
	public Vector3 vec1 = new Vector3 (10, 0, 0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay (startPoint, vec1, Color.yellow); //Draw ray is a static function in a class
		Debug.Log("Vec1 Mag: "+vec1.magnitude);
		Debug.Log ("Vec1 Normalized: " + Vector3.Normalize (vec1));

		Debug.Log ("Dot :"+Vector3.Dot (Vector3.right, Vector3.down));

		Debug.Log ("Facing :" + transform.forward);
		//if (Vector3.Dot(transform.forward, dir, Color.cyan);
	}
}
