using UnityEngine;
using System.Collections;

public class Glitch : MonoBehaviour {


	void Start () {
		StartCoroutine("ToggleRenderer");
	}
	

	IEnumerator ToggleRenderer()
	{
		while (true) 
		{
			yield return new WaitForSeconds (0.5f);
			this.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			yield return new WaitForSeconds (0.5f);
			this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}

///////TKS
