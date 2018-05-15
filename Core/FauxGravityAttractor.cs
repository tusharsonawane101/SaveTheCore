using UnityEngine;
using System.Collections;

public class FauxGravityAttractor : MonoBehaviour {
	
	public float gravity = -20;
	
	public void Attract(Transform body){
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 bodyUp = body.up;
		
		body.rigidbody2D.AddForce (gravityUp * gravity);
		//body.Transform.Translate (gravityUp * Time.deltaTime,gravity);
		Quaternion targetRotation = Quaternion.FromToRotation (bodyUp, gravityUp) * body.rotation;
		body.rotation = Quaternion.Slerp (body.rotation, targetRotation, 50 * Time.deltaTime);
	}
}

//////TKS