using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static	GameManager instance;
	public			bool		tutorialState = false;
	public			bool		gamePaused;

	public			int			dayCount = 0;
	private			float		dayValue = 600f;
	public			float		currentDayValue;

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

	void Start()
	{
		gamePaused = true;
		currentDayValue = 0f;
		dayCount = 0; // set to players current value in json
	}

	void Update()
	{
		if(!gamePaused)
			UpdateDayCounter();
	}

	public void QuitGame(bool value)
	{
		Application.Quit();
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#endif
	}

	private void UpdateDayCounter()
	{
		currentDayValue += Time.deltaTime;
		Debug.Log($"currentDayValue = {currentDayValue}");

		if ((int)currentDayValue % 200 == 0 && currentDayValue < dayValue)
		{
			Debug.Log("changing time of day");
			//change time of day
		}
		else if ((int)currentDayValue == 300 && dayCount/dayCount != 0)
			QuestsManager.instance.AddQuest();
		else if (currentDayValue >= dayValue)
		{
			dayCount++;
			currentDayValue = 0f;
			MenuStateManager.instance.SwitchState(MenuStateManager.dailySummaryState);
		}
	}

	public void TogglePause(){gamePaused = !gamePaused;}
}
