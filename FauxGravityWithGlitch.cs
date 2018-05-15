using UnityEngine;
using System.Collections;

public class FauxGravityWithGlitch : MonoBehaviour {
	
	public FauxGravityAttractor attractor;
	private Transform myTransform;
	
	
	void Start()
	{
		StartCoroutine("ToggleRenderer");
		//rigidbody2D.constraints = Rigidbody2D.FreezeRotation;
		//rigidbody2D.useGravity = false;
		myTransform = transform;
	}
	void Update(){
		attractor.Attract (myTransform);
	}
	IEnumerator ToggleRenderer()
	{
		while (true) 
		{
			yield return new WaitForSeconds (1.5f);
			this.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			yield return new WaitForSeconds (1.5f);
			this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}

///////TKS