using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CoreCollider : MonoBehaviour {
	public UImanager _otherscript;
	public AudioSource collideaudio;

	void Start()
	{
		collideaudio = GetComponent<AudioSource> ();
	}
	void OnCollisionEnter2D (Collision2D col){

		audio.Play();

		if((col.gameObject.name == "Red2(Clone)")||(col.gameObject.name == "RedGlitching(Clone)"))
		{
			Destroy (col.gameObject);
			ScoreCount.gscore += -1;

			if (transform.localScale.x < 0.1)
			{	ScoreCount.gscore += -1;

				print ("Game Over");

				Destroy (gameObject);
				_otherscript.gameOverActivated();
				//UImanager.GameOver=true;

				//ui.gameOverActivated();
			}
			else
			{
				transform.localScale += new Vector3 (-0.1f,-0.1f,0f);
			}
		}
		if((col.gameObject.name =="RedBig(Clone)")||(col.gameObject.name =="RedBigGlitching(Clone)"))
		{
			ScoreCount.gscore += -2;
			Destroy (col.gameObject);
			if (transform.localScale.x > 0.1)
			{

				transform.localScale += new Vector3 (-0.2f,-0.2f,0f);
				if(transform.localScale.x<0.1)
			
				{	
				//	ScoreCount.gscore += -2;
					print ("Game Over");
					
					Destroy (gameObject);
					_otherscript.gameOverActivated();
					//_otherscript.gameOverActivated();
					//UImanager.gameOverActivated();
					
					
				}
			}
			else
			{	
				ScoreCount.gscore += -2;
				print ("Game Over");
				
				Destroy (gameObject);
				_otherscript.gameOverActivated();
				//_otherscript.gameOverActivated();
				//UImanager.gameOverActivated();
				
				
			}

			
		}

		if ((col.gameObject.name == "Blue2(Clone)") || (col.gameObject.name == "BlueGlitching(Clone)")) {
			Destroy (col.gameObject);
			if (transform.localScale.x < 1.0) {
				transform.localScale += new Vector3 (0.1f, 0.1f, 0f);
				
			} 
			ScoreCount.gscore += 1;
		}
	}
}
/////////TKS