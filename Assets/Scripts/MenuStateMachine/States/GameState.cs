using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MenuBaseState
{
    public override void EnterState(MenuStateManager menu)
	{
		Debug.Log($"entered {this.GetType().Name}");
		SceneManager.LoadSceneAsync("Game");
		UiManager.instance.Toggle(UiPanel.Game);

		//start game loop
	}

    public override void HandleEscape(MenuStateManager menu, Scene currentScene)
	{
		menu.SwitchState(MenuStateManager.optionsState);
	}
}
