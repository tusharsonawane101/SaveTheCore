using UnityEngine;
using System.Collections;

public class Spiral : MonoBehaviour {
	public float unit;
	public float freq;
	public float x;
	public float y;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		y = y -( Mathf.Cos(Time.time*freq) / unit); 
		x = x -( Mathf.Sin(Time.time*freq) / unit);
		transform.position = new Vector2 (x, y);
		//transform.position.x = x;
	//	transform.position.y = y;
		unit += Time.deltaTime;
	}
}


/////////TKSSS