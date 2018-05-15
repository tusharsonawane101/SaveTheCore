using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//public Camera camera;
	public float speed;

	private Vector3 TouchPosition;
	//private Vector3 direction;
	//private
	void Start () {
		
	}





	void Update () {
		if(Input.GetKey ("left")) {
			print ("left key was pressed");
			transform.Rotate(new Vector3(0,0,45) * Time.deltaTime * 6);
		}
		if (Input .GetKey ("right")) {
			print ("right key is pressed");
			transform.Rotate (new Vector3 (0, 0, -45) * Time.deltaTime * 6);
		}
		
	}
	
}

/////TKS
