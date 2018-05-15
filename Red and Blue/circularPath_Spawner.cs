using UnityEngine;
using System.Collections;

public class circularPath_Spawner : MonoBehaviour {
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
		
		float x = Mathf .Cos (timeCounter)*width;
		float y = Mathf.Sin (timeCounter)*height;
		
		transform .position = new Vector2 (x, y);
	}
}

////TKS