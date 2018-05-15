using UnityEngine;
using System.Collections;

public class ShieldCollider : MonoBehaviour {



	void OnCollisionEnter2D (Collision2D col){
		
		if((col.gameObject.name =="Blue2(Clone)")||(col.gameObject.name =="BlueGlitching(Clone)"))
		{
			Destroy(col.gameObject);
			ScoreCount.gscore += 1;
			
		}
		
		if((col.gameObject.name == "Red2(Clone)")||(col.gameObject.name == "RedGlitching(Clone)"))
		{
			Destroy(col.gameObject); 
			
		}	
		if((col.gameObject.name =="RedBig(Clone)")||(col.gameObject.name =="RedBigGlitching(Clone)"))
		{
			Destroy(col.gameObject);
			ScoreCount.gscore += 2;
		}

	}

	public void GameOver()
	{
		Destroy(gameObject);

	}
}


//////TKS