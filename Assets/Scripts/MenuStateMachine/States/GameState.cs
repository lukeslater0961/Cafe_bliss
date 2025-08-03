using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MenuBaseState
{
    public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
		if (SceneManager.GetActiveScene().name != "Game")
			SceneManager.LoadSceneAsync("Game");
		UiManager.instance.Toggle(UiPanel.Game);
		if (GameManager.instance.gamePaused)
			GameManager.instance.TogglePause();
	}

    public override void HandleEscape(MenuStateManager menu, Scene currentScene)
	{
		GameManager.instance.TogglePause();
		menu.SwitchState(MenuStateManager.optionsState);
	}
}
