using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
	public static	GameManager instance;
	public			bool		tutorialState = false;
	public			int			dayCount = 0;


	void Awake()
	{
		if (instance == null)
		{
			DontDestroyOnLoad(this.gameObject);
			instance = this;
		}
		else
			Destroy(gameObject);
	}

	void Update()
	{
		if (dayCount % 1.5 == 0)
		{
			// call quest script to setup new quest 
		}
	}

	public void QuitGame(bool value)
	{
		Application.Quit();
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}
}
