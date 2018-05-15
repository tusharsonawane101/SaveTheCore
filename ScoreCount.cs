using UnityEngine;
using System.Collections;

public class ScoreCount : MonoBehaviour {
	
		public static int gscore;

	void Start () {
		gscore = 0;
	}

	

		void OnGUI()
	{
		{
			GUI.Label (new Rect (10, 10, 100, 20), "Score : " + gscore);
		}
	}
}


/////TKS