using UnityEngine;
using System.Collections;

public class FauxGravityBody : MonoBehaviour {
	
	public FauxGravityAttractor attractor;
	private Transform myTransform;
	public float x;
	public float y;
	public Rigidbody2D rb;
	void Start()
	{
	
		rb= GetComponent<Rigidbody2D>();

	
		//rigidbody2D.constraints = Rigidbody2D.FreezeRotation;
		//rigidbody2D.useGravity = false;
		myTransform = transform;
	}
	void Update(){
		attractor.Attract (myTransform);
	


		rb.AddForce (new Vector2(x,y),ForceMode2D.Force);
	}
}

//////TKS
