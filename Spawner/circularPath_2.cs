using UnityEngine;
using System.Collections;

public class circularPath_2 : MonoBehaviour {
	public float timeCounter;
	float speed;
	public float width;
	public float height;
	// Use this for initialization
	void Start () {
		//speed = 5;
		//	width = 4;
		//	height = 7;
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime;
		
		float x = Mathf .Sin (timeCounter)*width;
		float y = Mathf. Cos(timeCounter)*height;
		
		transform .position = new Vector2 (x, y);
	}
}

////TKS