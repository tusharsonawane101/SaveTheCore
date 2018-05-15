using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class UImanager : MonoBehaviour {

	public AudioSource gameoveraudio;
	public Image GameOverImg;
	public Button[] buttons;
	public Button[] Pausebuttons;
	public bool GameOver;
	void Start()
	{
		GameOver = false;
		gameoveraudio = GetComponent<AudioSource> ();
	}

	public void gameOverActivated()
	{
		GameOver = true;
		Destroy(GameObject.Find("Shield2"));

		foreach(Button button in buttons)
		{
			button.gameObject.SetActive(true);
		}
		audio.Play ();
		GameOverImg.enabled = true;

		//shieldscript.GameOver();

	}

	public void Play()
	{
		Application.LoadLevel("new 1");
	}	
	public void Pause()
	{
		if (Time.timeScale == 1) 
		{
			
			foreach(Button button in Pausebuttons)
			{
				button.gameObject.SetActive(true);
			}
			Time.timeScale = 0;
		}
		else if (Time.timeScale==0)
		{
			foreach(Button button in Pausebuttons)
			{
				button.gameObject.SetActive(false);
			}
			Time.timeScale = 1;
		}
	}
	public void Replay()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void Menu()
	{
		Application.LoadLevel ("Menu");///menu is other scene
	}
	public void Exit()
	{
		Application.Quit ();
	}
}

//////TKS